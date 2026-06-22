#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

namespace TheBonwater.Rebuild.Editor
{
    /// <summary>
    /// Ensures the TownScene has scene-owned SpawnPoints under TownWorldRoot.
    /// Preserves existing positions — never overwrites user-dragged objects.
    /// </summary>
    public static class EnsureSceneOwnedSpawnPoints
    {
        private struct SpawnDef
        {
            public string id;
            public float defaultX;
            public float defaultY;
            public bool isEnemySpawn;
            public string enemyType;
        }

        private static readonly SpawnDef[] SpawnDefs = new[]
        {
            new SpawnDef { id = "VillagerSpawn", defaultX = -70f, defaultY = 20f, isEnemySpawn = false, enemyType = "" },
            new SpawnDef { id = "RaidSpawn_Left", defaultX = -650f, defaultY = 120f, isEnemySpawn = false, enemyType = "" },
            new SpawnDef { id = "RaidSpawn_Right", defaultX = 650f, defaultY = 120f, isEnemySpawn = false, enemyType = "" },
            new SpawnDef { id = "EnemySpawn_Basic_01", defaultX = -500f, defaultY = -150f, isEnemySpawn = true, enemyType = "Basic" },
            new SpawnDef { id = "EnemySpawn_Fast_01", defaultX = -600f, defaultY = 0f, isEnemySpawn = true, enemyType = "Fast" },
            new SpawnDef { id = "EnemySpawn_Tank_01", defaultX = 500f, defaultY = -150f, isEnemySpawn = true, enemyType = "Tank" },
        };

        private static string _scenePath = "Assets/_Project/Scenes/TownScene.unity";

        [MenuItem("Tools/TheBonwater/Ensure Scene-Owned Spawn Points")]
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

            // Find TownWorldRoot
            var worldRoot = GameObject.Find("TownWorldRoot");
            if (worldRoot == null)
            {
                EditorUtility.DisplayDialog("Error", "TownWorldRoot not found. Run Tools/Rebuild/Create Town Scene first.", "OK");
                return;
            }

            // Find or create SpawnPoints parent
            var spawnPointsParent = worldRoot.transform.Find("SpawnPoints")?.gameObject;
            if (spawnPointsParent == null)
            {
                spawnPointsParent = new GameObject("SpawnPoints");
                spawnPointsParent.transform.SetParent(worldRoot.transform, false);
                var rect = spawnPointsParent.AddComponent<RectTransform>();
                rect.anchorMin = Vector2.zero;
                rect.anchorMax = Vector2.one;
                rect.sizeDelta = Vector2.zero;
                UnityEngine.Debug.Log("[SCENE_SLOT] Created SpawnPoints parent under TownWorldRoot");
            }

            int spawnCreated = 0;
            int spawnPreserved = 0;

            // Ensure Spawn Slots
            foreach (var def in SpawnDefs)
            {
                var existing = spawnPointsParent.transform.Find(def.id)?.gameObject;
                if (existing != null)
                {
                    EnsureSpawnComponents(existing, def);
                    spawnPreserved++;
                    UnityEngine.Debug.Log($"[SCENE_SLOT] Preserved existing spawn slot {def.id} at position");
                    continue;
                }

                // Check if it exists elsewhere and reparent
                existing = worldRoot.transform.Find(def.id)?.gameObject;
                if (existing != null && existing.transform.parent != spawnPointsParent.transform)
                {
                    existing.transform.SetParent(spawnPointsParent.transform, true);
                    EnsureSpawnComponents(existing, def);
                    spawnPreserved++;
                    UnityEngine.Debug.Log($"[SCENE_SLOT] Reparented existing spawn slot {def.id} to SpawnPoints");
                    continue;
                }

                // Create new spawn slot
                var go = new GameObject(def.id);
                go.transform.SetParent(spawnPointsParent.transform, false);
                var rect = go.AddComponent<RectTransform>();
                rect.anchoredPosition = new Vector2(def.defaultX, def.defaultY);
                rect.sizeDelta = new Vector2(64f, 64f);
                rect.localScale = Vector3.one;

                var img = go.AddComponent<Image>();
                img.raycastTarget = false;
                if (def.isEnemySpawn)
                {
                    img.color = new Color(1f, 0.2f, 0.2f, 0.2f); // Red semi-transparent for enemy spawns
                }
                else
                {
                    img.color = new Color(0.2f, 0.5f, 1f, 0.2f); // Blue semi-transparent for default spawns
                }

                var view = go.AddComponent<WorldObjectView>();
                view.objectId = def.id;
                view.objectType = "decoration";
                view.preserveManualPlacement = true;
                view.managedByBackend = false;
                view.rectTransform = rect;
                view.image = img;

                if (def.isEnemySpawn)
                {
                    var authoring = go.AddComponent<EnemySpawnPointAuthoring>();
                    authoring.spawnId = def.id;
                    authoring.enemyType = def.enemyType;
                }
                else
                {
                    var authoring = go.AddComponent<SpawnSlotAuthoring>();
                    authoring.slotId = def.id;
                }

                spawnCreated++;
                UnityEngine.Debug.Log($"[SCENE_SLOT] Created spawn slot {def.id} at ({def.defaultX}, {def.defaultY})");
            }

            UnityEditor.SceneManagement.EditorSceneManager.MarkSceneDirty(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene());

            string msg = $"Spawn Points: {spawnCreated} created, {spawnPreserved} preserved.";
            UnityEngine.Debug.Log($"[SCENE_SLOT] {msg}");
            EditorUtility.DisplayDialog("Ensure Scene-Owned Spawn Points", msg, "OK");
        }

        private static void EnsureSpawnComponents(GameObject go, SpawnDef def)
        {
            if (go.GetComponent<RectTransform>() == null)
            {
                go.AddComponent<RectTransform>();
            }

            var img = go.GetComponent<Image>();
            if (img == null)
            {
                img = go.AddComponent<Image>();
                img.raycastTarget = false;
                if (def.isEnemySpawn)
                {
                    img.color = new Color(1f, 0.2f, 0.2f, 0.2f);
                }
                else
                {
                    img.color = new Color(0.2f, 0.5f, 1f, 0.2f);
                }
            }

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
            }

            if (def.isEnemySpawn)
            {
                var authoring = go.GetComponent<EnemySpawnPointAuthoring>();
                if (authoring == null)
                {
                    authoring = go.AddComponent<EnemySpawnPointAuthoring>();
                    authoring.spawnId = def.id;
                    authoring.enemyType = def.enemyType;
                }
            }
            else
            {
                var authoring = go.GetComponent<SpawnSlotAuthoring>();
                if (authoring == null)
                {
                    authoring = go.AddComponent<SpawnSlotAuthoring>();
                    authoring.slotId = def.id;
                }
            }
        }
    }
}
#endif

