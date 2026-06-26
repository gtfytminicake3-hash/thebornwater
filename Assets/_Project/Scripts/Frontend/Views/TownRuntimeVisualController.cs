// Force recompile
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using TheBonwater.Rebuild.Data;

namespace TheBonwater.Rebuild {
    public class TownRuntimeVisualController : MonoBehaviour {
        public Transform worldRoot;
        private Dictionary<string, WorldObjectView> registry = new Dictionary<string, WorldObjectView>();
        private TownVisualLayoutDefinition layoutConfig;
        public HashSet<string> suppressedEnemyVisualIds = new HashSet<string>();
        private HashSet<string> sceneOwnedWorksiteIds = new HashSet<string>();
        private Dictionary<string, Transform> sceneOwnedSpawnPoints = new Dictionary<string, Transform>();
        private System.Collections.Generic.List<EnemySpawnPointAuthoring> sceneOwnedEnemySpawns = new System.Collections.Generic.List<EnemySpawnPointAuthoring>();
        private bool hasSpawnedRuntimeDecorations = false;
        private const bool DEBUG_VISUAL_AUDIT = false;
        private const bool DEBUG_AGENT_MOVE = false;
        private const bool DEBUG_ANIMATION_BIND = false;

        private void Start() {
            Initialize();
        }

        public void Initialize() {
            if (TownInteractionController.Instance != null) {
                // To avoid multiple subscriptions
                TownInteractionController.Instance.OnStateChanged -= HandleStateChanged;
                TownInteractionController.Instance.OnStateChanged += HandleStateChanged;
            }
            if (worldRoot == null) {
                var go = GameObject.Find("TownWorldRoot");
                if (go != null) worldRoot = go.transform;
            }

            if (GetComponent<LocalCombatVisualizer>() == null) {
                var cv = gameObject.AddComponent<LocalCombatVisualizer>();
                cv.visualController = this;
            }

            // Phase 8: Map Pan/Zoom
            if (gameObject.GetComponent<MapPanZoomController>() == null) {
                gameObject.AddComponent<MapPanZoomController>();
            }

            // Map Pan Hierarchy Fix: Reparent stray background/terrain siblings
            if (worldRoot != null) {
                var parent = worldRoot.parent;
                if (parent != null) {
                    var terrainLayer = worldRoot.Find("TerrainLayer");
                    if (terrainLayer != null) {
                        for (int i = parent.childCount - 1; i >= 0; i--) {
                            var sibling = parent.GetChild(i);
                            if (sibling != worldRoot && !sibling.name.Contains("HUD") && !sibling.name.Contains("Menu")) 
                            {
                                UnityEngine.Debug.Log($"[MAP_PAN_FIX] Found background sibling: {sibling.name}. Reparenting to TerrainLayer.");
                                sibling.SetParent(terrainLayer, true);
                                // Ensure it sits behind other things
                                sibling.SetAsFirstSibling();
                            }
                        }
                        
                        // We rely on the Scene/Editor setup for the background.
                        // No runtime override is needed since town_visual_layout.json now points to map.png
                        // and the user has manually positioned it.
                    }
                }
            }

            // Adopt manual placements
            if (worldRoot != null) {
                var views = worldRoot.GetComponentsInChildren<WorldObjectView>(true);
                foreach (var view in views) {
                    if (view.preserveManualPlacement && !string.IsNullOrEmpty(view.objectId)) {
                        registry[view.objectId] = view;
                    }
                }
            }

            // Load Layout Config
            #if UNITY_EDITOR
            var backend = GameServiceLocator.Backend as LocalGameBackend;
            if (backend != null && backend.repo != null) {
                layoutConfig = backend.repo.VisualLayout;
            }
            #endif

            // Phase 10F: Register scene-owned worksites from WorksiteAuthoring components
            RegisterSceneOwnedWorksites();
            RegisterSceneOwnedSpawnPoints();

            // Log Mandatory Hierarchy Info
            if (worldRoot != null) {
                var tLayer = worldRoot.Find("TerrainLayer");
                var dLayer = worldRoot.Find("DecorationLayer");
                
                int tChildren = tLayer != null ? tLayer.childCount : 0;
                int dChildren = dLayer != null ? dLayer.childCount : 0;
                
                bool bgFound = false;
                string bgPath = "";
                string bgSprite = "none";
                Vector2 bgSize = Vector2.zero;

                if (tLayer != null && tLayer.childCount > 0) {
                    var bg = tLayer.GetChild(0);
                    bgFound = true;
                    bgPath = "TownViewportPanel/TownWorldRoot/TerrainLayer/" + bg.name;
                    var img = bg.GetComponent<UnityEngine.UI.Image>();
                    if (img != null) {
                        bgSprite = img.sprite != null ? img.sprite.name : "null";
                        bgSize = bg.GetComponent<RectTransform>().sizeDelta;
                    }
                }

                UnityEngine.Debug.Log($"[WORLD_HIERARCHY] backgroundFound={bgFound} path={bgPath}");
                UnityEngine.Debug.Log($"[WORLD_HIERARCHY] backgroundSprite={bgSprite} size={bgSize.x},{bgSize.y}");
                UnityEngine.Debug.Log($"[WORLD_HIERARCHY] decorationCount={dChildren}");
                UnityEngine.Debug.Log($"[WORLD_HIERARCHY] terrainLayerChildren={tChildren}");

                if (!bgFound) UnityEngine.Debug.LogError("WORLD_BACKGROUND_ERROR: no background sprite under TownWorldRoot/TerrainLayer");
                if (dChildren == 0) UnityEngine.Debug.LogError("WORLD_DECORATION_ERROR: no static decorations under TownWorldRoot/DecorationLayer");
            }
            
            EnsureRuntimeMapBackground();
            SpawnMissingDecorations();
        }

        private WorldObjectView AdoptManualWorksiteObject(string objectId) {
            if (worldRoot == null || string.IsNullOrEmpty(objectId)) return null;
            if (registry.TryGetValue(objectId, out var registered) && registered != null) return registered;

            Transform found = null;
            string aliasA = objectId == "mine_1" ? "ironmine" : objectId == "forage_1" ? "bush" : "";
            string aliasB = objectId == "mine_1" ? "mine" : objectId == "forage_1" ? "forage" : "";
            foreach (var view in worldRoot.GetComponentsInChildren<WorldObjectView>(true)) {
                if (view != null && view.objectId == objectId) {
                    found = view.transform;
                    break;
                }
            }

            if (found == null) {
                foreach (var child in worldRoot.GetComponentsInChildren<Transform>(true)) {
                    string childName = child.name.ToLowerInvariant();
                    if (child.name == objectId
                        || (!string.IsNullOrEmpty(aliasA) && childName.Contains(aliasA))
                        || (!string.IsNullOrEmpty(aliasB) && childName.Contains(aliasB))) {
                        found = child;
                        break;
                    }
                }
            }

            if (found == null) return null;

            var adopted = found.GetComponent<WorldObjectView>();
            if (adopted == null) adopted = found.gameObject.AddComponent<WorldObjectView>();
            adopted.objectId = objectId;
            adopted.objectType = "decoration";
            adopted.preserveManualPlacement = true;
            adopted.managedByBackend = false;
            adopted.rectTransform = found.GetComponent<RectTransform>();
            adopted.image = found.GetComponent<Image>();
            if (adopted.rectTransform == null) adopted.rectTransform = found.gameObject.AddComponent<RectTransform>();
            if (adopted.image == null) {
                var spriteRenderer = found.GetComponent<SpriteRenderer>();
                Sprite existingSprite = spriteRenderer != null ? spriteRenderer.sprite : null;
                adopted.image = found.gameObject.AddComponent<Image>();
                adopted.image.raycastTarget = false;
                adopted.image.sprite = existingSprite;
            }
            if (adopted.image != null && adopted.image.sprite == null && layoutConfig != null && layoutConfig.objects != null) {
                var layoutObject = layoutConfig.objects.FirstOrDefault(o => o.id == objectId);
                if (layoutObject != null && !string.IsNullOrEmpty(layoutObject.asset)) {
                    Sprite loadedSp = null;
                    #if UNITY_EDITOR
                    loadedSp = UnityEditor.AssetDatabase.LoadAssetAtPath<Sprite>(layoutObject.asset);
                    #endif
                    if (loadedSp == null) {
                        loadedSp = LoadSpriteFromFile(System.IO.Path.GetFullPath(layoutObject.asset));
                    }
                    adopted.image.sprite = loadedSp;
                }
            }

            registry[objectId] = adopted;
            UnityEngine.Debug.Log($"[WORKSITE_ADOPTED] id={objectId} pos={adopted.rectTransform.anchoredPosition.x},{adopted.rectTransform.anchoredPosition.y}");
            return adopted;
        }

        /// <summary>
        /// Phase 10F: Scans scene for WorksiteAuthoring components and registers them.
        /// Scene-owned worksite wins over JSON layout.
        /// Populates sceneOwnedWorksiteIds for duplicate prevention.
        /// Falls back to AdoptManualWorksiteObject for worksites not found as scene objects.
        /// </summary>
        private void RegisterSceneOwnedWorksites()
        {
            if (worldRoot == null) return;

            sceneOwnedWorksiteIds.Clear();
            var authoringComponents = worldRoot.GetComponentsInChildren<WorksiteAuthoring>(true);
            
            foreach (var authoring in authoringComponents)
            {
                if (authoring == null || string.IsNullOrEmpty(authoring.worksiteId)) continue;
                
                string objectId = authoring.worksiteId;
                sceneOwnedWorksiteIds.Add(objectId);
                
                if (registry.ContainsKey(objectId))
                {
                    UnityEngine.Debug.Log($"[SCENE_WORKSITE] Already registered: {objectId}");
                    continue;
                }
                
                // Ensure WorldObjectView exists
                var view = authoring.GetComponent<WorldObjectView>();
                if (view == null)
                {
                    view = authoring.gameObject.AddComponent<WorldObjectView>();
                    view.objectId = objectId;
                    view.objectType = "decoration";
                    view.preserveManualPlacement = true;
                    view.managedByBackend = false;
                    view.image = authoring.GetComponent<UnityEngine.UI.Image>();
                    view.rectTransform = authoring.GetComponent<RectTransform>();
                }
                else
                {
                    view.preserveManualPlacement = true;
                    view.managedByBackend = false;
                }
                
                registry[objectId] = view;
                Vector2 pos = view.rectTransform != null ? view.rectTransform.anchoredPosition : Vector2.zero;
                UnityEngine.Debug.Log($"[SCENE_WORKSITE] Registered scene-owned {objectId} at ({pos.x},{pos.y})");
            }
            
            // Fallback: adopt missing core worksites if not found as scene objects
            string[] coreIds = { "mine_1", "forage_1", "coalMine_1", "farm_1" };
            foreach (string id in coreIds)
            {
                if (!sceneOwnedWorksiteIds.Contains(id))
                {
                    UnityEngine.Debug.LogWarning($"[SCENE_WORKSITE] Scene-owned {id} not found, falling back to AdoptManualWorksiteObject");
                    var adopted = AdoptManualWorksiteObject(id);
                    if (adopted == null)
                    {
                        UnityEngine.Debug.LogWarning($"[SCENE_WORKSITE] {id} not found anywhere — will be spawned by SpawnMissingDecorations");
                    }
                }
            }
        }

        private void RegisterSceneOwnedSpawnPoints()
        {
            if (worldRoot == null) return;

            sceneOwnedSpawnPoints.Clear();
            var authoringComponents = worldRoot.GetComponentsInChildren<SpawnSlotAuthoring>(true);
            
            foreach (var authoring in authoringComponents)
            {
                if (authoring == null || string.IsNullOrEmpty(authoring.slotId)) continue;
                
                string slotId = authoring.slotId;
                sceneOwnedSpawnPoints[slotId] = authoring.transform;
                UnityEngine.Debug.Log($"[SCENE_SPAWN] Registered scene-owned spawn point {slotId} at {authoring.transform.position}");

                // Disable Image component only during Play to hide dev markers
                if (Application.isPlaying) {
                    var img = authoring.GetComponent<UnityEngine.UI.Image>();
                    if (img != null) {
                        img.enabled = false;
                    }
                }
            }

            sceneOwnedEnemySpawns.Clear();
            var enemyAuthoringComponents = worldRoot.GetComponentsInChildren<EnemySpawnPointAuthoring>(true);
            foreach (var auth in enemyAuthoringComponents)
            {
                if (auth == null) continue;
                sceneOwnedEnemySpawns.Add(auth);
                UnityEngine.Debug.Log($"[SCENE_ENEMY_SPAWN] Registered scene-owned enemy spawn point {auth.spawnId} of type {auth.enemyType} at {auth.transform.position}");

                if (Application.isPlaying) {
                    var img = auth.GetComponent<UnityEngine.UI.Image>();
                    if (img != null) {
                        img.enabled = false;
                    }
                }
            }
        }

#if UNITY_EDITOR
        [ContextMenu("Save Worksite Positions To Layout JSON")]
        public void SaveWorksitePositionsToLayoutJson() {
            if (layoutConfig == null) {
                var backend = GameServiceLocator.Backend as LocalGameBackend;
                if (backend != null && backend.repo != null) layoutConfig = backend.repo.VisualLayout;
            }

            string jsonPath = "Assets/_Project/Data/Definitions/town_visual_layout.json";
            if (layoutConfig == null && System.IO.File.Exists(jsonPath)) {
                layoutConfig = JsonUtility.FromJson<TownVisualLayoutDefinition>(System.IO.File.ReadAllText(jsonPath));
            }
            if (layoutConfig == null || layoutConfig.objects == null) {
                UnityEngine.Debug.LogWarning("[WORKSITE_SAVE] layout missing, cannot save worksite positions");
                return;
            }

            SaveWorksitePositionNode("mine_1");
            SaveWorksitePositionNode("forage_1");
            SaveWorksitePositionNode("coalMine_1");

            string json = JsonUtility.ToJson(layoutConfig, true);
            System.IO.File.WriteAllText(jsonPath, json);
            UnityEditor.AssetDatabase.Refresh();
            UnityEngine.Debug.Log($"[WORKSITE_SAVE] wrote {jsonPath}");
        }

        private void SaveWorksitePositionNode(string objectId) {
            var view = AdoptManualWorksiteObject(objectId);
            if (view == null || view.rectTransform == null) {
                UnityEngine.Debug.LogWarning($"[WORKSITE_SAVE] missing visible object id={objectId}");
                return;
            }

            var node = layoutConfig.objects.FirstOrDefault(o => o.id == objectId);
            if (node == null) {
                UnityEngine.Debug.LogWarning($"[WORKSITE_SAVE] missing layout object id={objectId}");
                return;
            }

            node.x = view.rectTransform.anchoredPosition.x;
            node.y = view.rectTransform.anchoredPosition.y;
            UnityEngine.Debug.Log($"[WORKSITE_SAVE] id={objectId} x={node.x} y={node.y}");
        }
#endif

        private void EnsureRuntimeMapBackground() {
            if (worldRoot == null) return;
            
            // Cache transforms with safe null check
            Transform terrainLayer = null;
            try {
                terrainLayer = worldRoot.Find("TerrainLayer");
            } catch { }
            if (terrainLayer == null || terrainLayer.Equals(null)) {
                var tlGo = new GameObject("TerrainLayer");
                var tlT = tlGo.transform;
                try {
                    if (worldRoot != null && !worldRoot.Equals(null)) {
                        tlT.SetParent(worldRoot, false);
                        tlT.SetAsFirstSibling();
                    }
                } catch { }
                terrainLayer = tlT;
            }

            // Re-check terrainLayer is still valid
            Transform terrainLayerSafe = null;
            try { terrainLayerSafe = terrainLayer; if (terrainLayerSafe.Equals(null)) terrainLayerSafe = null; } catch { terrainLayerSafe = null; }
            if (terrainLayerSafe == null) {
                UnityEngine.Debug.LogError("[WORLD_BG] TerrainLayer transform is destroyed, recreating");
                var tlGo = new GameObject("TerrainLayer");
                if (worldRoot != null && !worldRoot.Equals(null)) {
                    tlGo.transform.SetParent(worldRoot, false);
                    tlGo.transform.SetAsFirstSibling();
                }
                terrainLayerSafe = tlGo.transform;
            }

            if (DEBUG_VISUAL_AUDIT) {
                bool mapBgExists = terrainLayerSafe.Find("MapBackground") != null;
                UnityEngine.Debug.Log($"[BgAudit] Scene object MapBackground before init: exists={mapBgExists}");
            }

            var bgList = new System.Collections.Generic.List<Transform>();
            for (int i = 0; i < terrainLayerSafe.childCount; i++) {
                bgList.Add(terrainLayerSafe.GetChild(i));
            }

            // 1. Find or create exactly one MapBackground
            Transform mapBg = null;
            try { mapBg = terrainLayerSafe.Find("MapBackground"); } catch { }
            if (mapBg == null || mapBg.Equals(null)) {
                var go = new GameObject("MapBackground");
                try {
                    go.transform.SetParent(terrainLayerSafe, false);
                } catch { }
                mapBg = go.transform;
            }
            
            // 2 & 3. Ensure Image and map.png
            GameObject mapBgGo = null;
            try { mapBgGo = mapBg.gameObject; if (mapBgGo.Equals(null)) mapBgGo = null; } catch { mapBgGo = null; }
            if (mapBgGo == null) {
                UnityEngine.Debug.LogError("[WORLD_BG] MapBackground GameObject destroyed, recreating");
                var go = new GameObject("MapBackground");
                try { go.transform.SetParent(terrainLayerSafe, false); } catch { }
                mapBg = go.transform;
                mapBgGo = go;
            }

            var img = mapBgGo.GetComponent<UnityEngine.UI.Image>();
            if (img == null) img = mapBgGo.AddComponent<UnityEngine.UI.Image>();

            string absPath = @"D:\Tinh\TheBonwater\Assets\_Project\ImportedDecoded\Texture2D\map.png";
            bool fileExists = System.IO.File.Exists(absPath);

            Texture2D tex = null;
#if UNITY_EDITOR
            tex = UnityEditor.AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/_Project/ImportedDecoded/Texture2D/map.png");
#endif
            if (tex == null && fileExists) {
                byte[] bytes = System.IO.File.ReadAllBytes(absPath);
                tex = new Texture2D(2, 2);
                tex.LoadImage(bytes);
            }

            bool texLoaded = tex != null;

            if (texLoaded) {
                img.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100f);
                img.rectTransform.anchorMin = Vector2.zero;
                img.rectTransform.anchorMax = Vector2.one;
                img.rectTransform.sizeDelta = Vector2.zero;
                img.rectTransform.anchoredPosition = Vector2.zero;
            }

            // 4. Ensure parent and first sibling
            try {
                mapBg.SetParent(terrainLayerSafe, false);
                mapBg.SetAsFirstSibling();
            } catch (System.Exception ex) {
                UnityEngine.Debug.LogWarning($"[WORLD_BG] Reparent failed: {ex.Message}");
            }

            // 6. Disable old fallbacks
            var disabledList = new System.Collections.Generic.List<string>();
            foreach (var child in bgList) {
                try {
                    if (child != mapBg && !child.Equals(null) && (child.name.Contains("bg") || child.name.Contains("Background") || child.name.Contains("Terrain") || child.name.Contains("fallback"))) {
                        child.gameObject.SetActive(false);
                        disabledList.Add(child.name);
                    }
                } catch { }
            }

            mapBgGo.SetActive(true);

            if (DEBUG_VISUAL_AUDIT) {
                UnityEngine.Debug.Log($"[BgAudit] MapBackground final sprite: {(img.sprite != null ? img.sprite.name : "null")}");
                UnityEngine.Debug.Log($"[BgAudit] MapBackground active: {mapBgGo.activeInHierarchy}");
                UnityEngine.Debug.Log($"[BgAudit] MapBackground parent: {(terrainLayerSafe != null ? terrainLayerSafe.name : "null")}");
            }
        }

        private void SpawnMissingDecorations() {
            if (hasSpawnedRuntimeDecorations) return;
            hasSpawnedRuntimeDecorations = true;
            
            if (layoutConfig != null && layoutConfig.objects != null) {
                var dLayer = worldRoot.Find("DecorationLayer");
                if (dLayer != null) {
                    foreach (var obj in layoutConfig.objects) {
                        if (obj.role == "decoration") {
                            // Phase 10F: Skip scene-owned worksites — they're already registered from WorksiteAuthoring
                            if (sceneOwnedWorksiteIds.Contains(obj.id))
                            {
                                if (!registry.ContainsKey(obj.id))
                                {
                                    // Should not happen, but log warning
                                    UnityEngine.Debug.LogWarning($"[SCENE_WORKSITE] Scene-owned {obj.id} in JSON layout but not in registry yet");
                                }
                                continue;
                            }
                            if (!registry.ContainsKey(obj.id)) {
                                var existingView = AdoptManualWorksiteObject(obj.id);
                                var existing = existingView != null ? existingView.transform : dLayer.Find(obj.id);
                                if (existing != null) {
                                    var view = existing.gameObject.GetComponent<WorldObjectView>();
                                    if (view == null) view = existing.gameObject.AddComponent<WorldObjectView>();
                                    view.objectId = obj.id;
                                    view.preserveManualPlacement = true;
                                    view.managedByBackend = false; // CRITICAL: prevent cleanup from destroying this
                                    
                                    view.image = existing.GetComponent<UnityEngine.UI.Image>();
                                    if (view.image == null) {
                                        var sr = existing.GetComponent<SpriteRenderer>();
                                        Sprite existingSprite = null;
                                        if (sr != null) {
                                            existingSprite = sr.sprite;
                                            UnityEngine.Object.DestroyImmediate(sr);
                                        }
                                        view.image = existing.gameObject.AddComponent<UnityEngine.UI.Image>();
                                        view.image.raycastTarget = false;
                                        view.image.sprite = existingSprite;
                                        if (existingSprite == null && !string.IsNullOrEmpty(obj.asset)) {
                                            // Try editor asset first, then runtime file load
                                            Sprite loadedSp = null;
                                            #if UNITY_EDITOR
                                            loadedSp = UnityEditor.AssetDatabase.LoadAssetAtPath<Sprite>(obj.asset);
                                            #endif
                                            if (loadedSp == null) {
                                                loadedSp = LoadSpriteFromFile(System.IO.Path.GetFullPath(obj.asset));
                                            }
                                            view.image.sprite = loadedSp;
                                        }
                                    }
                                    
                                    registry[obj.id] = view;
                                } else {
                                    // Spawn it dynamically
                                    var go = new GameObject(obj.id);
                                    go.transform.SetParent(dLayer, false);
                                    var view = go.AddComponent<WorldObjectView>();
                                    view.objectId = obj.id;
                                    view.preserveManualPlacement = true;
                                    view.managedByBackend = false; // CRITICAL: prevent cleanup from destroying this
                                    view.image = go.AddComponent<UnityEngine.UI.Image>();
                                    view.image.raycastTarget = false;
                                    view.rectTransform = go.GetComponent<RectTransform>();
                                    view.rectTransform.anchoredPosition = new Vector2(obj.x, obj.y);
                                    view.rectTransform.sizeDelta = new Vector2(obj.width, obj.height);
                                    
                                    if (!string.IsNullOrEmpty(obj.asset)) {
                                        Sprite loadedSp = null;
                                        #if UNITY_EDITOR
                                        loadedSp = UnityEditor.AssetDatabase.LoadAssetAtPath<Sprite>(obj.asset);
                                        #endif
                                        if (loadedSp == null) {
                                            loadedSp = LoadSpriteFromFile(System.IO.Path.GetFullPath(obj.asset));
                                        }
                                        view.image.sprite = loadedSp;
                                    }
                                    registry[obj.id] = view;
                                    UnityEngine.Debug.Log($"[RUNTIME_DECORATION_SPAWN] id={obj.id} pos={obj.x},{obj.y}");
                                }
                            }
                        }
                    }
                }
            }
        }

        public void HandleLoadedSnapshot(GameSnapshot snap) {
            if (worldRoot == null) return;
            
            UnityEngine.Debug.Log("[SAVELOAD_WORLD_REFRESH] source=load");
            
            // Clear local combat state
            var combatVisualizer = GetComponent<LocalCombatVisualizer>();
            if (combatVisualizer != null) {
                combatVisualizer.ResetAllCombats();
            }

            // Clean up stale suppression
            var snapEnemyIds = new HashSet<string>(snap.enemies.Select(e => e.id));
            var staleSuppressed = suppressedEnemyVisualIds.Where(id => !snapEnemyIds.Contains(id)).ToList();
            foreach (var stale in staleSuppressed) {
                suppressedEnemyVisualIds.Remove(stale);
            }

            // Suppress loaded enemies that are already dead/removePending
            foreach (var enemy in snap.enemies) {
                if (enemy.removePending || enemy.hp <= 0 || enemy.status == "Defeated") {
                    suppressedEnemyVisualIds.Add(enemy.id);
                    UnityEngine.Debug.Log($"[SAVELOAD_SUPPRESS_DEFEATED_ENEMY] enemy={enemy.id}");
                }
            }

            UnityEngine.Debug.Log($"[SAVELOAD_DUPLICATE_CHECK] villagers={snap.villagers.Count} buildings={snap.buildings.Count} tasks={snap.tasks.Count} enemies={snap.enemies.Count}");

            HandleStateChanged(snap);
        }

        public void HandleStateChanged(GameSnapshot snap) {
            if (worldRoot == null) return;
            
            CleanupDestroyedRegistryEntries();

            // 1) CACHE COMBAT POSITIONS
            bool activeRaid = snap.enemies.Any(e => e.status == "Active" && e.hp > 0 && !e.removePending);
            Dictionary<string, Vector2> preservedPos = new Dictionary<string, Vector2>();
            if (activeRaid) {
                foreach (var e in snap.enemies) {
                    if (e.status == "Active" && e.hp > 0 && !e.removePending) {
                        string id = "monster:" + e.id;
                        if (registry.ContainsKey(id) && registry[id] != null) {
                            preservedPos[id] = registry[id].rectTransform.anchoredPosition;
                        }
                    }
                }
                foreach (var v in snap.villagers) {
                    string id = "villager:" + v.id;
                    if (registry.ContainsKey(id) && registry[id] != null) {
                        preservedPos[id] = registry[id].rectTransform.anchoredPosition;
                    }
                }
            }

            // Reload layout dynamically in editor in case it changed
            #if UNITY_EDITOR
            var backend = GameServiceLocator.Backend as LocalGameBackend;
            if (backend != null && backend.repo != null) {
                layoutConfig = backend.repo.VisualLayout;
            }
            #endif

            List<string> expectedIds = new List<string>();

            // Ensure Animation Registry is loaded from Resources if missing
            var animRegistry = worldRoot.GetComponent<AnimationRegistry>();
            if (animRegistry == null) {
                var prefab = UnityEngine.Resources.Load<GameObject>("AnimationRegistryPrefab");
                if (prefab != null) {
                    var instance = UnityEngine.Object.Instantiate(prefab, worldRoot);
                    instance.name = "AnimationRegistry";
                }
            }

            // Buildings
            Dictionary<string, int> bldCounts = new Dictionary<string, int>();
            foreach (var bld in snap.buildings) {
                for (int i = 0; i < bld.count; i++) {
                    string id = $"building:{bld.id}:{i}";
                    expectedIds.Add(id);
                }
                bldCounts[bld.id] = bld.count;
            }

            // Construction Tasks
            int fallbackTaskCounter = 0;
            foreach (var task in snap.tasks) {
                if (task.type.StartsWith("Build")) {
                    string stableId = !string.IsNullOrEmpty(task.id) ? task.id : $"fallback_{fallbackTaskCounter++}";
                    string id = $"construction:{task.targetBuildingId}:{stableId}";
                    expectedIds.Add(id);
                }
            }

            // Villagers
            foreach (var v in snap.villagers) {
                if (v.isOnExpedition) continue;
                expectedIds.Add($"villager:{v.id}");
            }

            // Enemies
            foreach (var e in snap.enemies) {
                if (suppressedEnemyVisualIds.Contains(e.id)) continue;
                
                if (e.status == "Retreated") {
                    suppressedEnemyVisualIds.Add(e.id);
                    continue;
                }

                // 8A: No zombie respawn. If backend says it's defeated, don't spawn it on load.
                // However, if it's already in the registry (we were playing when it died), keep it until visualizer suppresses it.
                if (e.hp <= 0 || e.status == "Defeated" || e.removePending) {
                    if (!registry.ContainsKey($"monster:{e.id}")) {
                        continue;
                    }
                }
                expectedIds.Add($"monster:{e.id}");
            }

            // Remove unused
            var keysToRemove = registry.Keys.Where(k => {
                var view = registry[k];
                return view != null && view.managedByBackend && !expectedIds.Contains(k);
            }).ToList();

            foreach (var k in keysToRemove) {
                if (registry[k] != null && registry[k].gameObject != null) {
                    DestroyObject(registry[k].gameObject);
                }
                registry.Remove(k);
            }

            // Clean up suppressed enemies that no longer exist in snapshot
            var snapEnemyIds = new HashSet<string>(snap.enemies.Select(e => e.id));
            var staleSuppressed = suppressedEnemyVisualIds.Where(id => !snapEnemyIds.Contains(id)).ToList();
            foreach (var stale in staleSuppressed) {
                suppressedEnemyVisualIds.Remove(stale);
                UnityEngine.Debug.Log($"[ENEMY_VISUAL_SUPPRESSION_CLEARED] enemy={stale}");
            }

            // Log registry after cleanup
            if (DEBUG_VISUAL_AUDIT) {
                string remaining = string.Join(", ", registry.Keys);
                UnityEngine.Debug.Log($"DEBUG_REGISTRY_AFTER_CLEANUP: keys=[{remaining}]");
            }

            // Create or Update
            int fallbackCounter = 0;
            foreach (var id in expectedIds) {
                if (!registry.ContainsKey(id)) {
                    var go = new GameObject(id);
                    // Determine layer based on id
                    Transform targetLayer = worldRoot;
                    if (id.StartsWith("villager:")) targetLayer = worldRoot.Find("VillagerLayer");
                    else if (id.StartsWith("monster:")) targetLayer = worldRoot.Find("MonsterLayer");
                    else if (id.StartsWith("building:")) targetLayer = worldRoot.Find("BuildingLayer");
                    else if (id.StartsWith("construction:")) targetLayer = worldRoot.Find("ConstructionLayer");
                    if (targetLayer == null) targetLayer = worldRoot; // Fallback
                    
                    go.transform.SetParent(targetLayer, false);
                    
                    var view = go.AddComponent<WorldObjectView>();
                    view.objectId = id;
                    view.image = go.AddComponent<Image>();
                    view.image.raycastTarget = false;
                    view.image.preserveAspect = true;
                    view.rectTransform = go.GetComponent<RectTransform>();
                    
                    if (id.StartsWith("villager:") || id.StartsWith("monster:")) {
                        // Removed hardcoded AnimationLiteBob, handled by AnimationStateBinder now
                    }

                    registry[id] = view;
                    
                    // Initial Position logic
                    if (!view.preserveManualPlacement) {
                        ApplyPlacement(view, fallbackCounter++, snap);
                    }
                }

                var objView = registry[id];

                // Visual update logic
                UpdateVisualState(objView, id, snap);
            }

            // 2) RESTORE CACHED POSITIONS
            foreach (var kvp in preservedPos) {
                if (registry.ContainsKey(kvp.Key) && registry[kvp.Key] != null) {
                    registry[kvp.Key].rectTransform.anchoredPosition = kvp.Value;
                }
            }

            UpdateAgentTargets(snap);
        }

        private void UpdateAgentTargets(GameSnapshot snap) {
            // Also update Monster targets for 8C (No Guard -> monster moves to villager)
            foreach (var eData in snap.enemies) {
                if (eData.hp <= 0 || eData.status == "Defeated") continue;
                string id = "monster:" + eData.id;
                if (!registry.ContainsKey(id)) continue;
                var view = registry[id];
                if (view == null || view.gameObject == null) continue;
                
                // For now, if we don't have an agent view, we can't smoothly move it using the same code, 
                // but we added EnemyRuntimeView which is just a MonoBehavior.
                // Wait, how do monsters move? EnemyRuntimeView doesn't have SetTarget!
                // Let's just linearly interpolate them in Update() or let LocalCombatVisualizer do it.
            }

            var intendedPositions = new System.Collections.Generic.Dictionary<string, Vector2>();
            var intendedIds = new System.Collections.Generic.Dictionary<string, string>();
            var agentViews = new System.Collections.Generic.Dictionary<string, VillagerAgentView>();
            var worksiteAnchors = new System.Collections.Generic.Dictionary<string, Vector2>();
            var clampToWorksite = new System.Collections.Generic.Dictionary<string, bool>();

            foreach (var vData in snap.villagers) {
                string id = "villager:" + vData.id;
                if (!registry.ContainsKey(id)) continue;
                var view = registry[id];
                if (view == null || view.gameObject == null) continue;
                
                var agent = view.gameObject.GetComponent<VillagerAgentView>();
                if (agent == null) continue;

                if (vData.hp <= 0) {
                    agent.SetTarget(agent.rectTransform.anchoredPosition, "dead");
                    continue;
                }

                Vector2 targetPos = agent.rectTransform.anchoredPosition;
                string tId = "none";
                
                bool activeRaid = System.Linq.Enumerable.Any(snap.enemies, e => e.status == "Active" && e.hp > 0 && !e.removePending);
                if (activeRaid) {
                    targetPos = agent.rectTransform.anchoredPosition;
                    tId = "fleeing/combat";
                } else {
                    ResolveWorksiteAnchorForJob(vData, agent.rectTransform.anchoredPosition, snap, out targetPos, out tId);
                    Vector2 worksiteAnchor = targetPos;
                    bool hasWorksiteAnchor = ShouldClampAgentToWorksite(vData.job, tId);
                    
                    var sameTarget = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(snap.villagers, v => v.job == vData.job && v.hp > 0));
                    int slotIndex = sameTarget.IndexOf(vData);
                    if (slotIndex > 0) {
                        float angle = slotIndex * 60f * Mathf.Deg2Rad;
                        float radius = GetWorksiteSlotRadius(vData.job);
                        
                        targetPos += new Vector2(Mathf.Cos(angle) * radius, Mathf.Sin(angle) * radius);
                    }

                    worksiteAnchors[vData.id] = worksiteAnchor;
                    clampToWorksite[vData.id] = hasWorksiteAnchor;
                }

                intendedPositions[vData.id] = targetPos;
                intendedIds[vData.id] = tId;
                agentViews[vData.id] = agent;
            }

            // --- VISUAL OVERLAP RESOLVER ---
            bool globalActiveRaid = System.Linq.Enumerable.Any(snap.enemies, e => e.status == "Active" && e.hp > 0 && !e.removePending);
            float villagerRadius = 40f;
            int iterations = 4;
            
            var staticBlockers = new System.Collections.Generic.List<System.Tuple<Vector2, float>>();
            var dynamicEnemies = new System.Collections.Generic.List<System.Tuple<Vector2, float>>();
            if (!globalActiveRaid) {
                foreach (var viewItem in this.registry.Values) {
                    if (viewItem == null || viewItem.gameObject == null) continue;
                    var rt = viewItem.GetComponent<RectTransform>();
                    if (rt == null) continue;

                    string lowerId = viewItem.objectId.ToLowerInvariant();
                    if (lowerId.StartsWith("bonfire")) staticBlockers.Add(new System.Tuple<Vector2, float>(rt.anchoredPosition, 70f));
                    else if (lowerId.StartsWith("tree") || lowerId.StartsWith("wood")) staticBlockers.Add(new System.Tuple<Vector2, float>(rt.anchoredPosition, 60f));
                    else if (lowerId.StartsWith("building:") || lowerId.StartsWith("construction:")) staticBlockers.Add(new System.Tuple<Vector2, float>(rt.anchoredPosition, 80f));
                    else if (lowerId.StartsWith("monster:")) dynamicEnemies.Add(new System.Tuple<Vector2, float>(rt.anchoredPosition, 50f));
                }
            }

            var villagerIds = new System.Collections.Generic.List<string>(intendedPositions.Keys);
            for (int iter = 0; iter < iterations; iter++) {
                foreach (var vId in villagerIds) {
                    Vector2 pos = intendedPositions[vId];
                    
                    foreach (var blocker in staticBlockers) {
                        Vector2 delta = pos - blocker.Item1;
                        float dist = delta.magnitude;
                        float minDist = villagerRadius + blocker.Item2;
                        if (dist < minDist) {
                            if (dist < 0.1f) {
                                float angle = (vId.GetHashCode() % 360) * Mathf.Deg2Rad;
                                delta = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
                                dist = 1f;
                            }
                            pos += (delta / dist) * (minDist - dist + 2f);
                        }
                    }
                    
                    foreach (var enemy in dynamicEnemies) {
                        Vector2 delta = pos - enemy.Item1;
                        float dist = delta.magnitude;
                        float minDist = villagerRadius + enemy.Item2;
                        if (dist < minDist) {
                            if (dist < 0.1f) {
                                float angle = (vId.GetHashCode() % 360) * Mathf.Deg2Rad;
                                delta = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
                                dist = 1f;
                            }
                            pos += (delta / dist) * (minDist - dist + 2f);
                        }
                    }
                    
                    float vRad = globalActiveRaid ? 20f : 40f;
                    foreach (var otherId in villagerIds) {
                        if (vId == otherId) continue;
                        Vector2 otherPos = intendedPositions[otherId];
                        Vector2 delta = pos - otherPos;
                        float dist = delta.magnitude;
                        float minDist = villagerRadius + vRad;
                        if (dist < minDist) {
                            if (dist < 0.1f) {
                                float angle = ((vId.GetHashCode() ^ otherId.GetHashCode()) % 360) * Mathf.Deg2Rad;
                                delta = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
                                dist = 1f;
                            }
                            float push = (minDist - dist + 2f) * 0.5f;
                            pos += (delta / dist) * push;
                            intendedPositions[otherId] -= (delta / dist) * push;
                        }
                    }
                    
                    intendedPositions[vId] = pos;
                }
            }

            foreach (var vId in villagerIds) {
                if (!clampToWorksite.TryGetValue(vId, out bool shouldClamp) || !shouldClamp) continue;
                if (!worksiteAnchors.TryGetValue(vId, out Vector2 anchor)) continue;

                Vector2 delta = intendedPositions[vId] - anchor;
                const float maxWorksiteDistance = 45f;
                if (delta.magnitude > maxWorksiteDistance) {
                    intendedPositions[vId] = anchor + delta.normalized * maxWorksiteDistance;
                }
            }

            foreach (var vId in villagerIds) {
                var agent = agentViews[vId];
                agent.SetTarget(intendedPositions[vId], intendedIds[vId]);
                var vData = snap.villagers.Find(v => v.id == vId);
                if (vData != null) {
                    vData.state = agent.visualState; 
                    vData.targetId = agent.targetId;
                }
            }
        }

        private float GetWorksiteSlotRadius(string job) {
            if (job == "Builder") return 30f;
            if (job == "Blacksmith") return 28f;
            if (job == "towerGuard") return 25f;
            if (job == "Miner") return 30f;
            if (job == "coalMiner") return 30f;
            if (job == "Farmer") return 30f;
            if (job == "Forager") return 30f;
            if (job == "Guard") return 35f;
            if (job == "Woodcutter") return 35f;
            return 30f;
        }

        private bool ShouldClampAgentToWorksite(string job, string targetId) {
            if (string.IsNullOrEmpty(targetId)) return false;
            if (targetId == "fleeing/combat" || targetId == "dead" || targetId == "none") return false;
            if (job == "Builder") return targetId.StartsWith("construction:");
            if (job == "Blacksmith") return targetId.StartsWith("building:blacksmithsForge");
            if (job == "towerGuard") return targetId.StartsWith("building:guardTower");
            if (job == "Miner") return targetId == "mine_1" || targetId.ToLowerInvariant().Contains("mine") || targetId.ToLowerInvariant().Contains("iron");
            if (job == "coalMiner") return targetId == "coalMine_1" || targetId.ToLowerInvariant().Contains("coalmine") || targetId.ToLowerInvariant().Contains("coal");
            if (job == "Farmer") return targetId == "farm_1" || targetId.ToLowerInvariant().Contains("farm");
            if (job == "Forager") return targetId == "forage_1" || targetId.ToLowerInvariant().Contains("forage") || targetId.ToLowerInvariant().Contains("bush") || targetId.ToLowerInvariant().Contains("hunt");
            if (job == "Guard") return targetId.StartsWith("building:bonfire");
            return false;
        }

        private void ResolveWorksiteAnchorForJob(VillagerSnapshot vData, Vector2 currentPos, GameSnapshot snap, out Vector2 anchor, out string tId) {
            anchor = new Vector2(0, 50); // bonfire fallback
            tId = "bonfire"; // default fallback
            var bfr = System.Linq.Enumerable.FirstOrDefault(this.registry.Values, v => v != null && v.objectId.StartsWith("building:bonfire"));
            if (bfr != null) {
                var rt = bfr.GetComponent<RectTransform>();
                if (rt != null) anchor = rt.anchoredPosition;
                tId = bfr.objectId;
            }
            
            Vector2 GetPos(Transform t) {
                var rt = t.GetComponent<RectTransform>();
                if (rt != null) return rt.anchoredPosition;
                return new Vector2(t.localPosition.x, t.localPosition.y);
            }

            if (vData.job == "Woodcutter") {
                Transform bestTree = null;
                float bestDist = float.MaxValue;

                bool IsValidTree(Transform t, string k) {
                    if (t == null || !t.gameObject.activeInHierarchy || t.GetComponent<UnityEngine.UI.Button>() != null) return false;
                    string lowerN = k.ToLowerInvariant();
                    if (lowerN.Contains("btn_") || lowerN.Contains("job") || lowerN.Contains("panel")) return false;
                    if (lowerN.Contains("tree") || lowerN.Contains("wood")) return true;
                    return false;
                }

                foreach (var viewItem in this.registry.Values) {
                    if (viewItem == null || viewItem.gameObject == null) continue;
                    if (IsValidTree(viewItem.transform, viewItem.objectId)) {
                        float d = Vector2.Distance(currentPos, GetPos(viewItem.transform));
                        if (d < bestDist) { bestDist = d; bestTree = viewItem.transform; }
                    }
                }
                if (bestTree == null && worldRoot != null) {
                    foreach (var child in worldRoot.GetComponentsInChildren<Transform>(true)) {
                        if (IsValidTree(child, child.name)) {
                            float d = Vector2.Distance(currentPos, GetPos(child));
                            if (d < bestDist) { bestDist = d; bestTree = child; }
                        }
                    }
                }

                if (bestTree != null) {
                    anchor = GetPos(bestTree);
                    tId = bestTree.name;
                }
            }
            else if (vData.job == "Builder") {
                var tsk = System.Linq.Enumerable.FirstOrDefault(snap.tasks, t => t.status == "UnderConstruction" || t.status == "AwaitingResources");
                if (tsk != null) {
                    if (tsk.type == "UpgradeBuilding") {
                        var placement = snap.userPlacements.FirstOrDefault(p => p.id == tsk.targetPlacementId);
                        if (placement != null) {
                            anchor = new Vector2(placement.x, placement.y);
                            tId = placement.id;
                            return;
                        }
                    }
                    WorldObjectView bestSite = null;
                    string exactConstructionId = $"construction:{tsk.targetBuildingId}:{tsk.id}";
                    foreach (var viewItem in this.registry.Values) {
                        if (viewItem == null || viewItem.gameObject == null) continue;
                        if (viewItem.objectId == exactConstructionId) {
                            bestSite = viewItem;
                            break;
                        }
                    }
                    if (bestSite == null) {
                        foreach (var viewItem in this.registry.Values) {
                            if (viewItem == null || viewItem.gameObject == null) continue;
                            if (viewItem.objectId.StartsWith("construction:" + tsk.targetBuildingId + ":")) {
                                bestSite = viewItem;
                                break;
                            }
                        }
                    }
                    if (bestSite == null && snap.userPlacements != null) {
                        var placement = snap.userPlacements.FirstOrDefault(p => p.id == exactConstructionId);
                        if (placement != null) {
                            anchor = new Vector2(placement.x, placement.y);
                            tId = exactConstructionId;
                            return;
                        }
                    }
                    if (bestSite != null) { anchor = GetPos(bestSite.transform); tId = bestSite.objectId; }
                    else { anchor = new Vector2(-200, 150); tId = tsk.id; }
                }
            }
            else if (vData.job == "Guard") {
                // Guard (Melee) targets Bonfire by default. (Default anchor is already bonfire)
            }
            else if (vData.job == "towerGuard") {
                var twr = System.Linq.Enumerable.FirstOrDefault(this.registry.Values, v => v != null && v.objectId.StartsWith("building:guardTower"));
                if (twr != null) { anchor = GetPos(twr.transform); tId = twr.objectId; }
            }
            else if (vData.job == "Blacksmith") {
                // Find all alive Blacksmiths, ordered stably by ID
                var blacksmiths = snap.villagers
                    .Where(v => v.job == "Blacksmith" && v.hp > 0)
                    .OrderBy(v => v.id)
                    .ToList();
                int idx = blacksmiths.FindIndex(v => v.id == vData.id);

                // Get completed forge count from snap
                int completedCount = snap.buildings.FirstOrDefault(b => b.id == "blacksmithsForge")?.count ?? 0;

                // Find all completed blacksmiths forges from the registry, matching completed count
                var completedForges = this.registry.Values
                    .Where(v => {
                        if (v == null) return false;
                        if (!v.objectId.StartsWith("building:blacksmithsForge:")) return false;
                        var parts = v.objectId.Split(':');
                        if (parts.Length >= 3 && int.TryParse(parts[2], out int fIndex)) {
                            return fIndex < completedCount;
                        }
                        return false;
                    })
                    .OrderBy(v => v.objectId)
                    .ToList();

                if (idx >= 0 && completedForges.Count > 0) {
                    int forgeIndex = idx / 2;
                    if (forgeIndex < completedForges.Count) {
                        var assignedForge = completedForges[forgeIndex];
                        anchor = GetPos(assignedForge.transform);
                        tId = assignedForge.objectId;
                    }
                }
            }
            else if (vData.job == "Miner") {
                var mine = System.Linq.Enumerable.FirstOrDefault(this.registry.Values, v => v != null && (v.objectId.ToLowerInvariant().Contains("mine") || v.objectId.ToLowerInvariant().Contains("iron")));
                if (mine != null) { anchor = GetPos(mine.transform); tId = mine.objectId; }
                else { UnityEngine.Debug.LogWarning("[Miner] FALLBACK_WORKSITE used for miner!"); anchor = new Vector2(-450, 250); tId = "fallback_mine"; }
            }
            else if (vData.job == "coalMiner") {
                var coalmine = System.Linq.Enumerable.FirstOrDefault(this.registry.Values, v => v != null && (v.objectId.ToLowerInvariant().Contains("coalmine") || v.objectId.ToLowerInvariant().Contains("coal")));
                if (coalmine != null) { anchor = GetPos(coalmine.transform); tId = coalmine.objectId; }
                else { UnityEngine.Debug.LogWarning("[CoalMiner] FALLBACK_WORKSITE used for coalMiner!"); anchor = new Vector2(-650, 250); tId = "fallback_coalMine"; }
            }
            else if (vData.job == "Farmer") {
                var farm = System.Linq.Enumerable.FirstOrDefault(this.registry.Values, v => v != null && (v.objectId == "farm_1" || v.objectId.ToLowerInvariant().Contains("farm")));
                if (farm != null) { anchor = GetPos(farm.transform); tId = farm.objectId; }
                else { UnityEngine.Debug.LogWarning("[Farmer] FALLBACK_WORKSITE used for farmer!"); anchor = new Vector2(550, 100); tId = "fallback_farm"; }
            }
            else if (vData.job == "Forager") {
                var forage = System.Linq.Enumerable.FirstOrDefault(this.registry.Values, v => v != null && (v.objectId.ToLowerInvariant().Contains("forage") || v.objectId.ToLowerInvariant().Contains("bush") || v.objectId.ToLowerInvariant().Contains("hunt")));
                if (forage != null) { anchor = GetPos(forage.transform); tId = forage.objectId; }
                else { UnityEngine.Debug.LogWarning("[Forager] FALLBACK_WORKSITE used for forager!"); anchor = new Vector2(400, -150); tId = "fallback_forage"; }
            }
            else if (vData.job == "Idle") {
                // Return to bonfire
            }
        }

        private void ApplyPlacement(WorldObjectView view, int fallbackIdx, GameSnapshot snap) {
            bool found = false;
            
            // 1. Check user placements first
            if (snap != null && snap.userPlacements != null) {
                var up = snap.userPlacements.Find(p => p.id == view.objectId);
                if (up != null) {
                    view.rectTransform.anchoredPosition = new Vector2(up.x, up.y);
                    view.transform.localScale = Vector3.one;
                    return;
                }
            }

            if (layoutConfig != null && layoutConfig.placements != null) {
                string searchId = view.objectId;
                
                if (searchId.StartsWith("monster:")) {
                    // Fallback handled in UpdateVisualState directly to sync with EnemyState.x/y
                    return;
                }
                
                // If it's a construction site, map it to building:{type}:fallbackIdx as best effort
                // or just strip the taskId and match targetBuildingId
                if (searchId.StartsWith("construction:")) {
                    var parts = searchId.Split(':');
                    if (parts.Length >= 3) {
                        string typeId = parts[1];
                        // Try exact match in layout first (e.g. construction:hut)
                        var exactNode = layoutConfig.placements.FirstOrDefault(n => n.id == $"construction:{typeId}");
                        if (exactNode != null) {
                            view.rectTransform.anchoredPosition = new Vector2(exactNode.x + (fallbackIdx * 20), exactNode.y - (fallbackIdx * 20));
                            view.transform.localScale = new Vector3(exactNode.scale, exactNode.scale, 1f);
                            return;
                        }
                        
                        // Otherwise, map to the building placement slot
                        // Just find ANY building slot of this type that isn't taken? We don't have taken info here.
                        // We will try building:type:0, building:type:1 until one matches.
                        // For simplicity, just use the first one and offset.
                        searchId = $"building:{typeId}:0";
                    }
                }

                var node = layoutConfig.placements.FirstOrDefault(n => n.id == searchId);
                // If not found, try without index
                if (node == null && searchId.Contains(":")) {
                    var parts = searchId.Split(':');
                    node = layoutConfig.placements.FirstOrDefault(n => n.id == $"{parts[0]}:{parts[1]}");
                }

                if (node != null) {
                    view.rectTransform.anchoredPosition = new Vector2(node.x, node.y);
                    // Add slight offset for fallbackIdx to prevent perfect overlapping if multiple
                    if (view.objectId.StartsWith("construction:")) {
                        view.rectTransform.anchoredPosition += new Vector2(fallbackIdx * 10, -fallbackIdx * 10);
                    }
                    view.transform.localScale = new Vector3(node.scale, node.scale, 1f);
                    found = true;
                }
            }

            if (!found) {
                if (view.objectId.StartsWith("villager:")) {
                    var backend = GameServiceLocator.Backend as LocalGameBackend;
                    int vIndex = -1;
                    if (backend != null) {
                        var backendSnap = backend.GetSnapshot();
                        if (backendSnap != null) {
                            var vData = backendSnap.villagers.Find(v => v.id == view.objectId.Split(':')[1]);
                            if (vData != null) vIndex = backendSnap.villagers.IndexOf(vData);
                        }
                    }
                    if (vIndex < 0) vIndex = fallbackIdx;
                    
                    Vector2 idlePos;
                    Vector2 anchorPos = Vector2.zero;
                    bool hasVillagerSpawn = false;
                    if (sceneOwnedSpawnPoints.TryGetValue("VillagerSpawn", out var villagerSpawnT) && villagerSpawnT != null) {
                        var rect = villagerSpawnT.GetComponent<RectTransform>();
                        if (rect != null) {
                            anchorPos = rect.anchoredPosition;
                            hasVillagerSpawn = true;
                        }
                    }

                    if (hasVillagerSpawn) {
                        if (vIndex == 0) idlePos = anchorPos + new Vector2(-50f, 0f);
                        else if (vIndex == 1) idlePos = anchorPos + new Vector2(50f, 0f);
                        else if (vIndex == 2) idlePos = anchorPos + new Vector2(0f, -50f);
                        else if (vIndex == 3) idlePos = anchorPos + new Vector2(0f, 50f);
                        else {
                            int gridIndex = vIndex - 4;
                            int col = gridIndex % 3;
                            int row = gridIndex / 3;
                            float xOff = (col - 1) * 50f;
                            float yOff = (row + 2) * 50f;
                            idlePos = anchorPos + new Vector2(xOff, yOff);
                        }
                    } else {
                        if (vIndex == 0) idlePos = new Vector2(-70, 20);
                        else if (vIndex == 1) idlePos = new Vector2(70, 20);
                        else idlePos = new Vector2((vIndex % 3) * 50, (vIndex / 3) * 50);
                    }

                    view.rectTransform.anchoredPosition = idlePos;
                    UnityEngine.Debug.Log($"[VILLAGER_SPAWN_POSITION] id={view.objectId} index={vIndex} pos={idlePos.x},{idlePos.y}");
                } else {
                    UnityEngine.Debug.LogWarning($"LAYOUT_FALLBACK_USED: {view.objectId}");
                    int itemsPerRow = 5;
                    int row = fallbackIdx / itemsPerRow;
                    int col = fallbackIdx % itemsPerRow;
                    view.rectTransform.anchoredPosition = new Vector2(-300 + (col * 150), 200 - (row * 100));
                }
                view.transform.localScale = Vector3.one;
            }
        }

        private void UpdateVisualState(WorldObjectView view, string id, GameSnapshot snap) {
            string typeId = "";
            bool isConstruction = false;
            TaskSnapshot taskData = null;

            if (id.StartsWith("building:")) {
                typeId = id.Split(':')[1];
            } else if (id.StartsWith("construction:")) {
                var parts = id.Split(':');
                typeId = parts[1];
                string taskId = parts[2];
                isConstruction = true;
                
                view.targetBuildingId = typeId;
                view.taskId = taskId;
                view.objectType = "construction";

                // find exact task
                taskData = snap.tasks.Find(t => t.id == taskId);
                // Fallback to targetBuildingId if task.id was missing/fallback
                if (taskData == null) {
                    taskData = snap.tasks.Find(t => t.targetBuildingId == typeId);
                }
            } else if (id.StartsWith("villager:")) {
                typeId = "villagerMale"; // Default, could be refined
            } else if (id.StartsWith("monster:")) {
                var mData = snap.enemies.Find(e => e.id == id.Split(':')[1]);
                typeId = mData != null ? mData.typeId : "monsterFallback";
            }

            Sprite sp = null;
            if (id.StartsWith("monster:")) {
                var mData = snap.enemies.Find(e => e.id == id.Split(':')[1]);
                string rawType = mData != null ? mData.typeId : "SmallMonster";
                
                EnemySpawnPointAuthoring matchedSpawn = null;
                if (mData != null) {
                    string targetType = mData.monsterId;
                    var typeMatches = sceneOwnedEnemySpawns
                        .Where(s => s != null && s.enemyType.Equals(targetType, System.StringComparison.OrdinalIgnoreCase))
                        .OrderBy(s => s.gameObject.name)
                        .ToList();
                    int mIndex = snap.enemies.IndexOf(mData);
                    if (mIndex < 0) mIndex = 0;
                    if (typeMatches.Count > 0) {
                        matchedSpawn = typeMatches[mIndex % typeMatches.Count];
                    }
                }

                if (matchedSpawn != null && !string.IsNullOrEmpty(matchedSpawn.spriteOverridePath)) {
                    sp = LoadSpriteFromFile(matchedSpawn.spriteOverridePath);
                    if (sp != null) {
                        UnityEngine.Debug.Log($"[MONSTER_VISUAL_OVERRIDE] Applied manual spriteOverridePath={matchedSpawn.spriteOverridePath} from spawn point {matchedSpawn.gameObject.name}");
                    } else {
                        UnityEngine.Debug.LogWarning($"[MONSTER_VISUAL_OVERRIDE_FAILED] Invalid spriteOverridePath={matchedSpawn.spriteOverridePath} on spawn point {matchedSpawn.gameObject.name}");
                    }
                }

                if (sp == null && matchedSpawn != null && !string.IsNullOrEmpty(matchedSpawn.visualAssetKey)) {
                    sp = LoadSpriteFor(matchedSpawn.visualAssetKey);
                    if (sp != null) {
                        UnityEngine.Debug.Log($"[MONSTER_VISUAL_OVERRIDE] Applied visualAssetKey={matchedSpawn.visualAssetKey} from spawn point {matchedSpawn.gameObject.name}");
                    } else {
                        UnityEngine.Debug.LogWarning($"[MONSTER_VISUAL_OVERRIDE_FAILED] Invalid visualAssetKey={matchedSpawn.visualAssetKey} on spawn point {matchedSpawn.gameObject.name}");
                    }
                }

                if (sp == null) {
                    string selKey, selPath;
                    sp = LoadMonsterSpriteCascade(rawType, out selKey, out selPath);
                    if (sp != null) {
                        UnityEngine.Debug.Log($"[MONSTER_ASSET_SELECTED] type={rawType} key={selKey} path={selPath}");
                    } else {
                        UnityEngine.Debug.LogWarning($"[MONSTER_VISUAL_FALLBACK] Failed to load any sprite for type={rawType}");
                    }
                }
            } else {
                var backend = GameServiceLocator.Backend as LocalGameBackend;
                var bdef = backend?.repo?.GetBuilding(typeId);
                if (bdef != null && !string.IsNullOrEmpty(bdef.assetKey)) {
                    sp = LoadSpriteFor(bdef.assetKey);
                } else {
                    sp = LoadSpriteFor(typeId);
                }
            }
            
            // Set main sprite
            if (sp != null) {
                view.image.sprite = sp;
                view.image.color = isConstruction ? new Color(1f, 1f, 1f, 0.5f) : Color.white;
                view.rectTransform.sizeDelta = new Vector2(100, 100 * (sp.texture.height / (float)sp.texture.width));
            } else {
                view.image.sprite = null;
                view.image.color = new Color(1f, 0f, 0f, 0.5f); // Red semi-transparent square if no sprite
                view.rectTransform.sizeDelta = new Vector2(64, 64);
            }

            if (id.StartsWith("monster:")) {
                var mData = snap.enemies.Find(e => e.id == id.Split(':')[1]);
                string status = mData != null ? mData.status : "Active";
                UnityEngine.Debug.Log($"[MONSTER_VISUAL_SPAWN] id={id} type={typeId} asset={(sp != null ? sp.name : "FALLBACK")} status={status}");
                
                if (mData != null) {
                    if (mData.x == 0 && mData.y == 0) {
                        Transform spawnPointT = null;
                        
                        string targetType = mData.monsterId; // "Basic", "Fast", "Tank"
                        var typeMatches = sceneOwnedEnemySpawns
                            .Where(s => s != null && s.enemyType.Equals(targetType, System.StringComparison.OrdinalIgnoreCase))
                            .OrderBy(s => s.gameObject.name)
                            .ToList();

                        int mIndex = snap.enemies.IndexOf(mData);
                        if (mIndex < 0) mIndex = 0;

                        if (typeMatches.Count > 0) {
                            var matchedAuth = typeMatches[mIndex % typeMatches.Count];
                            spawnPointT = matchedAuth.transform;
                        } else {
                            // Fallback to Phase 10I RaidSpawn_* selection
                            var raidSpawns = new List<Transform>();
                            var allAuthoring = worldRoot.GetComponentsInChildren<SpawnSlotAuthoring>(true);
                            foreach (var auth in allAuthoring) {
                                if (auth != null && (
                                    (!string.IsNullOrEmpty(auth.slotId) && auth.slotId.StartsWith("RaidSpawn")) ||
                                    (auth.gameObject.name.StartsWith("RaidSpawn"))
                                )) {
                                    raidSpawns.Add(auth.transform);
                                }
                            }
                            raidSpawns = raidSpawns.OrderBy(t => t.gameObject.name).ToList();
                            if (raidSpawns.Count > 0) {
                                spawnPointT = raidSpawns[mIndex % raidSpawns.Count];
                            }
                        }

                        if (spawnPointT != null) {
                            var rect = spawnPointT.GetComponent<RectTransform>();
                            if (rect != null) {
                                Vector2 spawnPos = rect.anchoredPosition;
                                float xOffset = (mIndex % 3 - 1) * 35f;
                                float yOffset = (mIndex / 3) * 35f;
                                mData.x = spawnPos.x + xOffset;
                                mData.y = spawnPos.y + yOffset;
                                UnityEngine.Debug.Log($"[RaidSpawn] Enemy {mData.id} ({targetType}) spawned at spawn point {spawnPointT.name} at ({mData.x}, {mData.y})");
                            }
                        }
                        else if (mData.nx > 0 || mData.ny > 0) {
                            var trees = new System.Collections.Generic.List<Transform>();
                            foreach (var child in worldRoot.GetComponentsInChildren<Transform>(true)) {
                                string lowerN = child.name.ToLowerInvariant();
                                if (lowerN.Contains("tree") || lowerN.Contains("wood") || lowerN.Contains("forest") || lowerN.Contains("pine")) {
                                    trees.Add(child);
                                }
                            }

                            if (trees.Count > 0) {
                                var selectedTree = trees[UnityEngine.Random.Range(0, trees.Count)];
                                Vector3 localPos = worldRoot.InverseTransformPoint(selectedTree.position);
                                mData.x = localPos.x;
                                mData.y = localPos.y;
                                UnityEngine.Debug.Log($"[RaidSpawn] final enemy={mData.id} spawned at tree={selectedTree.name} localPos={localPos}");
                            } else {
                                var bg = worldRoot.Find("TerrainLayer/MapBackground");
                                if (bg != null) {
                                    var sr = bg.GetComponent<SpriteRenderer>();
                                    if (sr != null) {
                                        Vector2 pos = MapPlacementService.MapNormalizedToWorld(mData.nx, mData.ny, sr.bounds);
                                        Vector3 localPos = worldRoot.InverseTransformPoint(pos);
                                        mData.x = localPos.x;
                                        mData.y = localPos.y;
                                        UnityEngine.Debug.Log($"[RaidSpawn] fallback enemy={mData.id} nx={mData.nx} ny={mData.ny} localPos={localPos}");
                                    }
                                }
                            }
                        }
                    }
                    view.rectTransform.anchoredPosition = new Vector2(mData.x, mData.y);
                    view.transform.localScale = Vector3.one;
                }
            }

            if (sp == null) {
                var lblGo = new GameObject("FallbackLabel");
                lblGo.transform.SetParent(view.transform, false);
                var lblTxt = lblGo.AddComponent<UnityEngine.UI.Text>();
                lblTxt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                lblTxt.text = "MISSING: " + typeId;
                lblTxt.alignment = TextAnchor.MiddleCenter;
                lblTxt.color = Color.white;
                var lblRect = lblGo.GetComponent<RectTransform>();
                lblRect.anchorMin = Vector2.zero; lblRect.anchorMax = Vector2.one; lblRect.sizeDelta = Vector2.zero;
            }

            if (isConstruction) {
                var viewScript = view.gameObject.GetComponent<BuildingRuntimeView>() ?? view.gameObject.AddComponent<BuildingRuntimeView>();
                viewScript.SetConstructionState(taskData);
            } else if (id.StartsWith("building:")) {
                var viewScript = view.gameObject.GetComponent<BuildingRuntimeView>() ?? view.gameObject.AddComponent<BuildingRuntimeView>();
                viewScript.SetCompleteState();
                
                int level = 1;
                if (snap.userPlacements != null) {
                    var place = snap.userPlacements.Find(p => p.id == id);
                    if (place != null) level = place.level;
                }
                viewScript.SetLevel(level);
            } else if (id.StartsWith("villager:")) {
                var vData = snap.villagers.Find(v => v.id == id.Split(':')[1]);
                if (DEBUG_VISUAL_AUDIT) {
                    int vIndex = snap.villagers.IndexOf(vData);
                    UnityEngine.Debug.Log($"[VILLAGER_ID_DUMP] index={vIndex} id={vData.id} name={vData.name} visualKey={id}");
                }

                var viewScript = view.gameObject.GetComponent<VillagerRuntimeView>() ?? view.gameObject.AddComponent<VillagerRuntimeView>();
                viewScript.SetState(vData);

                var agent = view.gameObject.GetComponent<VillagerAgentView>() ?? view.gameObject.AddComponent<VillagerAgentView>();
                agent.villagerId = vData.id;
                agent.currentJob = vData.job;
                
                if (DEBUG_AGENT_MOVE) {
                    Vector2 targetPos = agent.rectTransform.anchoredPosition;
                    UnityEngine.Debug.Log($"[AGENT_POSITION_PRESERVE] villager={vData.id} pos={targetPos.x},{targetPos.y} reason=snapshot_refresh");
                }
                
                // Target logic moved to UpdateVillagerTargets
                
                vData.state = agent.visualState; 
                vData.targetId = agent.targetId;

                var hpBar = view.gameObject.GetComponentInChildren<HealthBarView>();
                if (hpBar == null) {
                    var hpGo = new GameObject("HealthBar");
                    hpGo.transform.SetParent(view.transform, false);
                    hpBar = hpGo.AddComponent<HealthBarView>();
                    hpBar.Initialize(vData.id, "villager", 100);
                }
                hpBar.UpdateHp(vData.hp);

            } else if (id.StartsWith("monster:")) {
                var mData = snap.enemies.Find(e => e.id == id.Split(':')[1]);
                var viewScript = view.gameObject.GetComponent<EnemyRuntimeView>() ?? view.gameObject.AddComponent<EnemyRuntimeView>();
                viewScript.SetState(mData);

                var hpBar = view.gameObject.GetComponentInChildren<HealthBarView>();
                if (hpBar == null) {
                    var hpGo = new GameObject("HealthBar");
                    hpGo.transform.SetParent(view.transform, false);
                    hpBar = hpGo.AddComponent<HealthBarView>();
                    int fallbackHp = (mData != null && mData.hp > 0) ? mData.hp : 20;
                    hpBar.Initialize(mData != null ? mData.id : "unknown", "enemy", fallbackHp);
                }
                if (mData != null) {
                    hpBar.UpdateHp(mData.hp);
                }
            }

            // Animation mapping
            var animRegistry = worldRoot.GetComponentInChildren<AnimationRegistry>();
            var binder = view.gameObject.GetComponent<AnimationStateBinder>() ?? view.gameObject.AddComponent<AnimationStateBinder>();
            binder.objectId = id;

            if (DEBUG_ANIMATION_BIND) {
                UnityEngine.Debug.Log($"[ANIMATION_BIND] id={id} type={binder.objectType}");
            }

            string animKey = null;
            if (id.StartsWith("villager:")) {
                binder.objectType = "villager";
                var vData = snap.villagers.Find(v => v.id == id.Split(':')[1]);
                if (vData != null) {
                    if (vData.hp <= 0) {
                        animKey = "villager.death";
                    } else if (vData.state == "Moving") {
                        animKey = "villager.walk";
                    } else {
                        switch (vData.job) {
                            case "Builder": animKey = "villager.construction"; break;
                            case "Woodcutter": animKey = "villager.work"; break;
                            case "Guard": animKey = "villager.guard"; break;
                            default: animKey = "villager.idle"; break;
                        }
                    }
                }
            } else if (isConstruction) {
                binder.objectType = "construction";
                animKey = "villager.construction";
            } else if (id.StartsWith("building:")) {
                binder.objectType = "building";
                if (typeId == "bonfire") animKey = "bonfire.loop";
                else binder.DisableAnimation();
            } else if (id.StartsWith("monster:")) {
                binder.objectType = "monster";
                var mData = snap.enemies.Find(e => e.id == id.Split(':')[1]);
                if (mData != null) {
                    if (mData.hp > 0 && mData.status != "Defeated") animKey = "monster.idle";
                    else animKey = "monster.death";
                }
            }

            if (!string.IsNullOrEmpty(animKey) && animKey != "NONE") {
                if (animRegistry != null) {
                    var entry = animRegistry.entries.Find(e => e.key == animKey);
                    // Fallbacks requested
                    if (entry == null && animKey == "villager.work") {
                        entry = animRegistry.entries.Find(e => e.key == "villager.walk") ?? animRegistry.entries.Find(e => e.key == "villager.idle");
                    }
                    if (entry == null && animKey == "villager.guard") {
                        entry = animRegistry.entries.Find(e => e.key == "villager.idle");
                    }
                    if (entry == null && isConstruction) {
                        binder.Fallback("Missing clip for construction");
                    } else {
                        binder.Bind(animKey, entry);
                    }
                } else {
                    binder.Fallback("No AnimationRegistry found");
                }
            }
        }

        public Sprite LoadSpriteFor(string id) {
            var repo = (GameServiceLocator.Backend as LocalGameBackend)?.repo;
            if (repo != null && repo.AssetMap != null) {
                var kvp = repo.AssetMap.assets.FirstOrDefault(k => k.Key.Equals(id, System.StringComparison.OrdinalIgnoreCase));
                if (!string.IsNullOrEmpty(kvp.Value)) {
                    return LoadSpriteFromFile(kvp.Value);
                }
                
                // Try fallbacks for hardcoded map keys if exact not found
                if (id == "monsterFallback") {
                    kvp = repo.AssetMap.assets.FirstOrDefault(k => k.Key.Equals("smallMonster", System.StringComparison.OrdinalIgnoreCase));
                    if (!string.IsNullOrEmpty(kvp.Value)) return LoadSpriteFromFile(kvp.Value);
                }
            }
            return null;
        }

        public string NormalizeEnemyTypeId(string raw) {
            if (string.IsNullOrEmpty(raw)) return "";
            if (raw.Equals("SmallMonster", System.StringComparison.OrdinalIgnoreCase)) return "smallMonster";
            return raw.ToLowerInvariant().Replace("_", "").Replace(" ", "");
        }

        public Sprite LoadMonsterSpriteCascade(string rawType, out string selectedKey, out string selectedPath) {
            selectedKey = null;
            selectedPath = null;
            var repo = (GameServiceLocator.Backend as LocalGameBackend)?.repo;
            if (repo == null || repo.AssetMap == null) return null;

            string normalized = NormalizeEnemyTypeId(rawType);
            
            string[] keysToTry = new string[] {
                $"enemy.{normalized}",
                $"enemy.{rawType}",
                "monster.fallback",
                "monster_fallback"
            };

            foreach (var k in keysToTry) {
                var kvp = repo.AssetMap.assets.FirstOrDefault(a => a.Key.Equals(k, System.StringComparison.OrdinalIgnoreCase));
                if (!string.IsNullOrEmpty(kvp.Value)) {
                    bool exists = System.IO.File.Exists(kvp.Value);
                    UnityEngine.Debug.Log($"[MONSTER_ASSET_LOOKUP] rawType={rawType} normalized={normalized} key={k} path={kvp.Value} exists={exists}");
                    if (exists) {
                        selectedKey = k;
                        selectedPath = kvp.Value;
                        UnityEngine.Debug.Log($"[MONSTER_ASSET_SELECTED] type={rawType} path={selectedPath}");
                        return LoadSpriteFromFile(kvp.Value);
                    }
                } else {
                    UnityEngine.Debug.Log($"[MONSTER_ASSET_LOOKUP] rawType={rawType} normalized={normalized} key={k} path=null exists=false");
                }
            }
            return null;
        }

        private Sprite LoadSpriteFromFile(string path) {
            if (System.IO.File.Exists(path)) {
                var bytes = System.IO.File.ReadAllBytes(path);
                var tex = new Texture2D(2, 2);
                if (tex.LoadImage(bytes)) {
                    return Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
                }
            }
            return null;
        }

        private void DestroyObject(GameObject go) {
            if (go == null) return;
            if (Application.isPlaying) {
                go.SetActive(false); // Hide immediately so it doesn't interfere with queries
                Destroy(go);
            } else {
                DestroyImmediate(go);
            }
        }

        private void CleanupDestroyedRegistryEntries() {
            if (this.registry == null) return;
            
            var deadKeys = new System.Collections.Generic.List<string>();
            foreach (var kvp in this.registry) {
                var view = kvp.Value;
                bool isDead = false;
                if (view == null) {
                    isDead = true;
                } else {
                    try {
                        var _ = view.gameObject;
                    } catch (MissingReferenceException) {
                        isDead = true;
                    }
                }
                
                if (isDead) {
                    deadKeys.Add(kvp.Key);
                }
            }
            
            foreach (var key in deadKeys) {
                this.registry.Remove(key);
            }
            
            if (deadKeys.Count > 0) {
                UnityEngine.Debug.Log($"[REGISTRY_CLEANUP] removed={deadKeys.Count} reason=destroyed_reference");
            }
        }

        public void DumpWorldRegistry() {
            CleanupDestroyedRegistryEntries();
            UnityEngine.Debug.Log($"[WORLD_REGISTRY_DUMP_START] count={this.registry.Count}");
            foreach (var kvp in this.registry) {
                string key = kvp.Key;
                GameObject go = null;
                try {
                    if (kvp.Value != null) go = kvp.Value.gameObject;
                } catch { go = null; }
                
                string gName = go != null ? go.name : "null";
                Vector2 pos = Vector2.zero;
                try {
                    if (kvp.Value != null && kvp.Value.rectTransform != null) pos = kvp.Value.rectTransform.anchoredPosition;
                } catch { }
                bool active = go != null ? go.activeInHierarchy : false;
                UnityEngine.Debug.Log($"[WORLD_REGISTRY_DUMP] key={key} name={gName} pos={pos.x},{pos.y} active={active}");
            }
            UnityEngine.Debug.Log($"[WORLD_REGISTRY_DUMP_END]");
        }
    }
    
    public class AnimationLiteBob : MonoBehaviour {
        private RectTransform rect;
        private float startY;
        private float offset;
        private void Start() {
            rect = GetComponent<RectTransform>();
            startY = rect.anchoredPosition.y;
            offset = Random.Range(0f, 2f);
        }
        private void Update() {
            if (rect != null) {
                rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, startY + Mathf.Sin(Time.time * 3f + offset) * 10f);
            }
        }
    }

    public class BuildingRuntimeView : MonoBehaviour {
        private Text txtProgress;
        private GameObject overlay;
        private Text txtLevel;
        private void EnsureOverlay() {
            if (overlay == null) {
                overlay = new GameObject("ConstructionLabel");
                overlay.transform.SetParent(transform, false);
                var img = overlay.AddComponent<Image>();
                img.color = new Color(0, 0, 0, 0.5f);
                var r = overlay.GetComponent<RectTransform>();
                r.anchorMin = Vector2.zero; r.anchorMax = Vector2.one; r.sizeDelta = Vector2.zero;
                
                var txtGo = new GameObject("ProgressText");
                txtGo.transform.SetParent(overlay.transform, false);
                var tr = txtGo.AddComponent<RectTransform>();
                tr.anchorMin = Vector2.zero; tr.anchorMax = Vector2.one; tr.sizeDelta = Vector2.zero;
                txtProgress = txtGo.AddComponent<Text>();
                txtProgress.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                txtProgress.alignment = TextAnchor.MiddleCenter;
                txtProgress.color = Color.yellow;
            }
        }
        private void EnsureLevelLabel() {
            if (txtLevel == null) {
                var txtGo = new GameObject("LevelLabel");
                txtGo.transform.SetParent(transform, false);
                var tr = txtGo.AddComponent<RectTransform>();
                tr.anchoredPosition = new Vector2(0, 45);
                tr.sizeDelta = new Vector2(100, 20);
                txtLevel = txtGo.AddComponent<Text>();
                txtLevel.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                txtLevel.alignment = TextAnchor.MiddleCenter;
                txtLevel.color = Color.yellow;
                txtLevel.fontSize = 18;
            }
        }
        public void SetConstructionState(TaskSnapshot task) {
            EnsureOverlay();
            overlay.SetActive(true);
            if (task != null) {
                if (task.status == "AwaitingResources") {
                    txtProgress.text = "NEED RES";
                } else {
                    txtProgress.text = $"{task.currentCompletion}/{task.finalCompletion}";
                }
            }
        }
        public void SetCompleteState() {
            if (overlay != null) overlay.SetActive(false);
        }
        public void SetLevel(int level) {
            if (level > 1) {
                EnsureLevelLabel();
                txtLevel.text = $"Lv{level}";
                txtLevel.gameObject.SetActive(true);
            } else {
                if (txtLevel != null) txtLevel.gameObject.SetActive(false);
            }
        }
    }

    public class VillagerRuntimeView : MonoBehaviour {
        private Text txtLabel;
        private void EnsureLabel() {
            if (txtLabel == null) {
                var txtGo = new GameObject("EntityLabel");
                txtGo.transform.SetParent(transform, false);
                var tr = txtGo.AddComponent<RectTransform>();
                tr.anchoredPosition = new Vector2(0, 40);
                tr.sizeDelta = new Vector2(100, 30);
                txtLabel = txtGo.AddComponent<Text>();
                txtLabel.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                txtLabel.alignment = TextAnchor.MiddleCenter;
                txtLabel.color = Color.white;
            }
        }
        public void SetState(VillagerSnapshot v) {
            if (v == null) return;
            EnsureLabel();
            txtLabel.text = $"{v.job}\n{v.hp}HP";
        }
    }

    public class EnemyRuntimeView : MonoBehaviour {
        private Text txtLabel;
        private void EnsureLabel() {
            if (txtLabel == null) {
                var txtGo = new GameObject("EntityLabel");
                txtGo.transform.SetParent(transform, false);
                var tr = txtGo.AddComponent<RectTransform>();
                tr.anchoredPosition = new Vector2(0, 50);
                tr.sizeDelta = new Vector2(100, 30);
                txtLabel = txtGo.AddComponent<Text>();
                txtLabel.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                txtLabel.alignment = TextAnchor.MiddleCenter;
                txtLabel.color = Color.red;
            }
        }
        public void SetState(EnemyState e) {
            if (e == null) return;
            EnsureLabel();
            txtLabel.text = $"{e.displayName}\n{e.hp}HP";
        }
    }
}
