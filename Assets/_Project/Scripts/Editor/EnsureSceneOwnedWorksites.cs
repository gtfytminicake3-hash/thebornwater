#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using TheBonwater.Rebuild.Diagnostics;

namespace TheBonwater.Rebuild.Editor
{
    /// <summary>
    /// Ensures the TownScene has scene-owned Worksite objects under TownWorldRoot/Worksites.
    /// Creates missing worksites (mine_1, forage_1, coalMine_1, farm_1) with RectTransform,
    /// Image visual, WorldObjectView, and WorksiteAuthoring.
    /// Preserves existing positions — never overwrites user-dragged worksites.
    /// </summary>
    public static class EnsureSceneOwnedWorksites
    {
        private struct WorksiteDef
        {
            public string id;
            public string jobId;
            public string assetKey;
            public string spritePath;
            public float defaultX;
            public float defaultY;
            public float width;
            public float height;
        }

        private static readonly WorksiteDef[] WorksiteDefs = new[]
        {
            new WorksiteDef { id = "mine_1", jobId = "Miner", assetKey = "ironMine", spritePath = "Assets/_Project/ImportedDecoded/Sprite/ironMine.png", defaultX = -450f, defaultY = 250f, width = 128f, height = 128f },
            new WorksiteDef { id = "forage_1", jobId = "Forager", assetKey = "bushes", spritePath = "Assets/_Project/ImportedDecoded/Sprite/bushes.png", defaultX = 400f, defaultY = -150f, width = 128f, height = 128f },
            new WorksiteDef { id = "coalMine_1", jobId = "coalMiner", assetKey = "coalMine", spritePath = "Assets/_Project/ImportedDecoded/Sprite/coalMine.png", defaultX = -650f, defaultY = 250f, width = 128f, height = 128f },
            new WorksiteDef { id = "farm_1", jobId = "Farmer", assetKey = "farm", spritePath = "Assets/_Project/ImportedDecoded/Sprite/farm.png", defaultX = 550f, defaultY = 100f, width = 128f, height = 128f },
        };

        private static string _scenePath = "Assets/_Project/Scenes/TownScene.unity";

        [MenuItem("Tools/TheBonwater/Ensure Scene-Owned Worksites")]
        public static void Execute()
        {
            // Ensure TownScene is open
            if (!UnityEngine.SceneManagement.SceneManager.GetActiveScene().name.StartsWith("TownScene"))
            {
                bool opened = false;
                if (File.Exists(_scenePath))
                {
                    UnityEditor.SceneManagement.EditorSceneManager.OpenScene(_scenePath);
                    opened = true;
                }
                if (!opened)
                {
                    EditorUtility.DisplayDialog("Error", "Could not find or open TownScene.unity. Ensure the scene exists at: " + _scenePath, "OK");
                    return;
                }
            }

            // Find or create TownWorldRoot
            var worldRoot = GameObject.Find("TownWorldRoot");
            if (worldRoot == null)
            {
                EditorUtility.DisplayDialog("Error", "TownWorldRoot not found. Run Tools/Rebuild/Create Town Scene first.", "OK");
                return;
            }

            // Find or create Worksites parent
            var worksitesParent = worldRoot.transform.Find("Worksites")?.gameObject;
            if (worksitesParent == null)
            {
                worksitesParent = new GameObject("Worksites");
                worksitesParent.transform.SetParent(worldRoot.transform, false);
                var wRect = worksitesParent.AddComponent<RectTransform>();
                wRect.anchorMin = Vector2.zero;
                wRect.anchorMax = Vector2.one;
                wRect.sizeDelta = Vector2.zero;
                UnityEngine.Debug.Log("[SCENE_WORKSITE] Created Worksites parent under TownWorldRoot");
            }

            int created = 0;
            int preserved = 0;
            int updated = 0;

            foreach (var def in WorksiteDefs)
            {
                var existing = worksitesParent.transform.Find(def.id)?.gameObject;
                if (existing != null)
                {
                    // Preserve existing — do NOT move it
                    EnsureComponents(existing, def);
                    preserved++;
                    UnityEngine.Debug.Log($"[SCENE_WORKSITE] Preserved existing {def.id} at position");
                    continue;
                }

                // Also check if it exists elsewhere in the hierarchy (legacy placement)
                existing = worldRoot.transform.Find(def.id)?.gameObject;
                if (existing != null && existing.transform.parent != worksitesParent.transform)
                {
                    // Reparent it
                    existing.transform.SetParent(worksitesParent.transform, true);
                    EnsureComponents(existing, def);
                    reparented++;
                    UnityEngine.Debug.Log($"[SCENE_WORKSITE] Reparented existing {def.id} to Worksites");
                    continue;
                }

                // Create new worksite
                var go = new GameObject(def.id);
                go.transform.SetParent(worksitesParent.transform, false);
                var rect = go.AddComponent<RectTransform>();
                rect.anchoredPosition = new Vector2(def.defaultX, def.defaultY);
                rect.sizeDelta = new Vector2(def.width, def.height);
                rect.localScale = Vector3.one;

                // Add Image with sprite
                var img = go.AddComponent<Image>();
                img.raycastTarget = false;
                Sprite sp = AssetDatabase.LoadAssetAtPath<Sprite>(def.spritePath);
                if (sp != null)
                {
                    img.sprite = sp;
                    img.color = Color.white;
                }
                else
                {
                    img.color = new Color(0.5f, 0.5f, 0.5f, 0.8f);
                    UnityEngine.Debug.LogWarning($"[SCENE_WORKSITE] Missing sprite at {def.spritePath} for {def.id}, using fallback color");
                }

                // Add WorldObjectView
                var view = go.AddComponent<WorldObjectView>();
                view.objectId = def.id;
                view.objectType = "decoration";
                view.preserveManualPlacement = true;
                view.managedByBackend = false;
                view.rectTransform = rect;
                view.image = img;

                // Add WorksiteAuthoring
                EnsureComponents(go, def);

                created++;
                UnityEngine.Debug.Log($"[SCENE_WORKSITE] Created {def.id} at ({def.defaultX}, {def.defaultY})");
            }

            UnityEditor.SceneManagement.EditorSceneManager.MarkSceneDirty(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene());

            string msg = $"Scene-Owned Worksites: {created} created, {preserved} preserved, {reparented} reparented";
            UnityEngine.Debug.Log($"[SCENE_WORKSITE] {msg}");
            EditorUtility.DisplayDialog("Scene-Owned Worksites", msg, "OK");
        }

        private static int reparented = 0;

        private static void EnsureComponents(GameObject go, WorksiteDef def)
        {
            // Ensure RectTransform
            if (go.GetComponent<RectTransform>() == null)
            {
                go.AddComponent<RectTransform>();
                UnityEngine.Debug.Log($"[SCENE_WORKSITE] Added RectTransform to {def.id}");
            }

            // Ensure Image
            var img = go.GetComponent<Image>();
            if (img == null)
            {
                img = go.AddComponent<Image>();
                img.raycastTarget = false;
                Sprite sp = AssetDatabase.LoadAssetAtPath<Sprite>(def.spritePath);
                if (sp != null) img.sprite = sp;
                img.color = Color.white;
                UnityEngine.Debug.Log($"[SCENE_WORKSITE] Added Image to {def.id}");
            }

            // Ensure WorldObjectView
            var view = go.GetComponent<WorldObjectView>();
            if (view == null)
            {
                view = go.AddComponent<WorldObjectView>();
                view.objectId = def.id;
                view.objectType = "decoration";
                view.preserveManualPlacement = true;
                view.managedByBackend = false;
                view.rectTransform = go.GetComponent<RectTransform>();
                view.image = img;
                UnityEngine.Debug.Log($"[SCENE_WORKSITE] Added WorldObjectView to {def.id}");
            }

            // Ensure WorksiteAuthoring
            var authoring = go.GetComponent<WorksiteAuthoring>();
            if (authoring == null)
            {
                authoring = go.AddComponent<WorksiteAuthoring>();
                authoring.worksiteId = def.id;
                authoring.jobId = def.jobId;
                authoring.assetKey = def.assetKey;
                UnityEngine.Debug.Log($"[SCENE_WORKSITE] Added WorksiteAuthoring to {def.id}");
            }
        }
    }
}
#endif
