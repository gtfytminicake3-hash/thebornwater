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
                        
                        if (terrainLayer.childCount == 0) {
                            UnityEngine.Debug.Log($"[MAP_PAN_FIX] No background found. Creating default fallback background.");
                            var bg = new GameObject("DefaultSceneBg");
                            bg.transform.SetParent(terrainLayer, false);
                            var rect = bg.AddComponent<RectTransform>();
                            rect.anchorMin = Vector2.zero; rect.anchorMax = Vector2.one;
                            rect.sizeDelta = Vector2.zero;
                            var img = bg.AddComponent<UnityEngine.UI.Image>();
                            img.color = new Color(0.2f, 0.4f, 0.2f); // Neutral dark green
                            
                            var lblGo = new GameObject("FallbackLabel");
                            lblGo.transform.SetParent(bg.transform, false);
                            var lblTxt = lblGo.AddComponent<Text>();
                            lblTxt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                            lblTxt.text = "MISSING: background";
                            lblTxt.alignment = TextAnchor.MiddleCenter;
                            lblTxt.fontSize = 48;
                            lblTxt.color = Color.white;
                            var lblRect = lblGo.GetComponent<RectTransform>();
                            lblRect.anchorMin = Vector2.zero; lblRect.anchorMax = Vector2.one;
                            lblRect.sizeDelta = Vector2.zero;
                        }
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
                expectedIds.Add($"villager:{v.id}");
            }

            // Enemies
            foreach (var e in snap.enemies) {
                if (!suppressedEnemyVisualIds.Contains(e.id)) {
                    expectedIds.Add($"monster:{e.id}");
                }
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
            string remaining = string.Join(", ", registry.Keys);
            UnityEngine.Debug.Log($"DEBUG_REGISTRY_AFTER_CLEANUP: keys=[{remaining}]");

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
                        ApplyPlacement(view, fallbackCounter++);
                    }
                }

                var objView = registry[id];

                // Visual update logic
                UpdateVisualState(objView, id, snap);
            }

            UpdateVillagerTargets(snap);
        }

        private void UpdateVillagerTargets(GameSnapshot snap) {
            foreach (var vData in snap.villagers) {
                string id = "villager:" + vData.id;
                if (!registry.ContainsKey(id)) continue;
                var view = registry[id];
                if (view == null || view.gameObject == null) continue;
                
                var agent = view.gameObject.GetComponent<VillagerAgentView>();
                if (agent == null) continue;

                Vector2 targetPos = agent.rectTransform.anchoredPosition;
                string tId = "none";
                int vIndex = snap.villagers.IndexOf(vData);

                if (vData.job == "Woodcutter") {
                    Transform bestTree = null;
                    float bestDist = float.MaxValue;
                    string bestSource = "none";

                    bool IsValidTree(Transform t, string k) {
                        if (t == null) return false;
                        if (!t.gameObject.activeInHierarchy) return false;
                        if (t.GetComponent<UnityEngine.UI.Button>() != null) return false;
                        
                        string lowerN = k.ToLowerInvariant();
                        if (lowerN.Contains("btn_") || lowerN.Contains("button") || lowerN.Contains("text") || 
                            lowerN.Contains("panel") || lowerN.Contains("canvas") || lowerN.Contains("hud") || 
                            lowerN.Contains("eventlog") || lowerN.Contains("selectedvillagerpanel") || 
                            lowerN.Contains("jobselectionmodal") || lowerN.Contains("villager:") || 
                            lowerN.Contains("monster:") || lowerN.Contains("bonfire") || lowerN.Contains("hut") || 
                            lowerN.Contains("storage") || lowerN.Contains("construction:")) {
                            return false;
                        }

                        if (lowerN.Contains("tree") || lowerN.Contains("wood") || lowerN.Contains("forest") || lowerN.Contains("pine")) {
                            return true;
                        }
                        return false;
                    }

                    Vector2 GetPos(Transform t) {
                        var rt = t.GetComponent<RectTransform>();
                        if (rt != null) return rt.anchoredPosition;
                        return new Vector2(t.localPosition.x, t.localPosition.y);
                    }

                    foreach (var viewItem in this.registry.Values) {
                        if (viewItem == null || viewItem.gameObject == null) continue;
                        if (IsValidTree(viewItem.transform, viewItem.objectId)) {
                            Vector2 p = GetPos(viewItem.transform);
                            float d = Vector2.Distance(agent.rectTransform.anchoredPosition, p);
                            UnityEngine.Debug.Log($"[TREE_TARGET_CANDIDATE] key={viewItem.objectId} name={viewItem.gameObject.name} pos={p.x},{p.y} reason=accepted:registry");
                            if (d < bestDist) {
                                bestDist = d;
                                bestTree = viewItem.transform;
                                bestSource = "registry";
                            }
                        }
                    }

                    if (bestTree == null && worldRoot != null) {
                        foreach (var child in worldRoot.GetComponentsInChildren<Transform>(true)) {
                            if (IsValidTree(child, child.name)) {
                                Vector2 p = GetPos(child);
                                float d = Vector2.Distance(agent.rectTransform.anchoredPosition, p);
                                UnityEngine.Debug.Log($"[TREE_TARGET_CANDIDATE] key={child.name} name={child.name} pos={p.x},{p.y} reason=accepted:worldRoot");
                                if (d < bestDist) {
                                    bestDist = d;
                                    bestTree = child;
                                    bestSource = "worldRoot";
                                }
                            }
                        }
                    }

                    if (bestTree != null) {
                        targetPos = GetPos(bestTree);
                        tId = bestTree.name;
                        UnityEngine.Debug.Log($"[TREE_TARGET_SELECTED] villager={vData.id} target={tId} pos={targetPos.x},{targetPos.y} source={bestSource}");
                        UnityEngine.Debug.Log($"[AGENT_TARGET] villager={vData.id} job=Woodcutter target={tId} pos={targetPos.x},{targetPos.y}");
                    } else {
                        // Maintain targetPos (don't fallback to dummy coordinates)
                        tId = "missing_tree";
                        UnityEngine.Debug.Log($"[AGENT_TARGET_MISSING] villager={vData.id} job=Woodcutter reason=no_valid_runtime_tree");
                    }
                } else if (vData.job == "Builder") {
                    var tsk = snap.tasks.FirstOrDefault(t => t.status == "UnderConstruction" || t.status == "AwaitingResources");
                    if (tsk != null) {
                        Transform bestSite = null;
                        foreach (var viewItem in this.registry.Values) {
                            if (viewItem == null || viewItem.gameObject == null) continue;
                            if (viewItem.objectId.StartsWith("construction:" + tsk.targetBuildingId) || viewItem.objectId.Contains("construction")) {
                                bestSite = viewItem.transform;
                                break;
                            }
                        }
                        if (bestSite != null) {
                            targetPos = bestSite.GetComponent<RectTransform>().anchoredPosition;
                            tId = bestSite.name;
                            UnityEngine.Debug.Log($"[AGENT_TARGET] villager={vData.id} job=Builder target={tId} pos={targetPos.x},{targetPos.y} source=worldObject");
                        } else {
                            targetPos = new Vector2(-200, 150); // Mock construction position
                            tId = tsk.id;
                            UnityEngine.Debug.Log($"[AGENT_TARGET_MISSING] villager={vData.id} job=Builder reason=no construction visual found");
                        }
                    } else {
                        targetPos = new Vector2(0, 0);
                        tId = "bonfire";
                    }
                } else if (vData.job == "Guard") {
                    Transform bestEnemy = null;
                    string foundMonsterId = null;
                    
                    var activeEnemy = snap.enemies.FirstOrDefault(e => e.status == "Active");
                    if (activeEnemy != null) {
                        foundMonsterId = activeEnemy.id;
                    }
                    
                    if (foundMonsterId != null) {
                        var viewItem = this.registry.Values.FirstOrDefault(v => v != null && v.gameObject != null && v.objectId == "monster:" + foundMonsterId);
                        if (viewItem != null) bestEnemy = viewItem.transform;
                    }

                    if (bestEnemy == null) {
                        var viewItem = this.registry.Values.FirstOrDefault(v => v != null && v.gameObject != null && v.objectId.StartsWith("monster:"));
                        if (viewItem != null) {
                            bestEnemy = viewItem.transform;
                            foundMonsterId = viewItem.objectId.Split(':')[1];
                        }
                    }

                    if (bestEnemy == null && worldRoot != null) {
                        foreach (var child in worldRoot.GetComponentsInChildren<Transform>(true)) {
                            if (child.name.StartsWith("monster:")) {
                                bestEnemy = child;
                                foundMonsterId = child.name.Split(':')[1];
                                break;
                            }
                        }
                    }

                    if (bestEnemy != null) {
                        targetPos = bestEnemy.GetComponent<RectTransform>() != null ? bestEnemy.GetComponent<RectTransform>().anchoredPosition : Vector2.zero;
                        tId = "monster:" + foundMonsterId;
                        string statusStr = activeEnemy != null ? activeEnemy.status : "Unknown";
                        UnityEngine.Debug.Log($"[GUARD_TARGET_ENEMY] villager={vData.id} enemy={foundMonsterId} status={statusStr} target={tId} pos={targetPos.x},{targetPos.y} source=visibleMonster");
                    } else {
                        targetPos = new Vector2(0, 0); // Fallback
                        tId = "bonfire";
                        UnityEngine.Debug.Log($"[GUARD_TARGET_MISSING] villager={vData.id} reason=no visible monster");
                    }
                } else if (vData.job == "Idle") {
                    if (vIndex == 0) targetPos = new Vector2(-70, 20);
                    else if (vIndex == 1) targetPos = new Vector2(70, 20);
                    else targetPos = new Vector2((vIndex % 3) * 50, (vIndex / 3) * 50);
                    tId = "idleSlot";
                    UnityEngine.Debug.Log($"[AGENT_IDLE_TARGET] villager={vData.id} pos={targetPos.x},{targetPos.y}");
                }
                
                agent.SetTarget(targetPos, tId);
                vData.state = agent.visualState; 
                vData.targetId = agent.targetId;
            }
        }

        private void ApplyPlacement(WorldObjectView view, int fallbackIdx) {
            bool found = false;
            if (layoutConfig != null && layoutConfig.placements != null) {
                string searchId = view.objectId;
                
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
                        var snap = backend.GetSnapshot();
                        if (snap != null) {
                            var vData = snap.villagers.Find(v => v.id == view.objectId.Split(':')[1]);
                            if (vData != null) vIndex = snap.villagers.IndexOf(vData);
                        }
                    }
                    if (vIndex < 0) vIndex = fallbackIdx;
                    
                    Vector2 idlePos;
                    if (vIndex == 0) idlePos = new Vector2(-70, 20);
                    else if (vIndex == 1) idlePos = new Vector2(70, 20);
                    else idlePos = new Vector2((vIndex % 3) * 50, (vIndex / 3) * 50);

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
                string selKey, selPath;
                sp = LoadMonsterSpriteCascade(rawType, out selKey, out selPath);
                if (sp != null) {
                    UnityEngine.Debug.Log($"[MONSTER_ASSET_SELECTED] type={rawType} key={selKey} path={selPath}");
                } else {
                    UnityEngine.Debug.Log($"MONSTER_ASSET_MISSING: {rawType} key=all_fallbacks");
                    UnityEngine.Debug.Log($"[MONSTER_VISUAL_FALLBACK] reason=sprite load failed");
                }
            } else {
                sp = LoadSpriteFor(typeId);
            }
            
            // Set main sprite
            if (sp != null) {
                view.image.sprite = sp;
                view.image.color = isConstruction ? new Color(1f, 1f, 1f, 0.5f) : Color.white;
                view.rectTransform.sizeDelta = new Vector2(100, 100 * (sp.texture.height / (float)sp.texture.width));
                
                if (id.StartsWith("monster:")) {
                    var mData = snap.enemies.Find(e => e.id == id.Split(':')[1]);
                    string status = mData != null ? mData.status : "Active";
                    UnityEngine.Debug.Log($"[MONSTER_VISUAL_SPAWN] id={id} type={typeId} asset={sp.name} status={status}");
                }
            } else {
                if (id.StartsWith("monster:")) {
                    var mData = snap.enemies.Find(e => e.id == id.Split(':')[1]);
                    string status = mData != null ? mData.status : "Active";
                    UnityEngine.Debug.Log($"[MONSTER_VISUAL_SPAWN] id={id} type={typeId} asset=FALLBACK_LABEL status={status}");
                }

                view.image.sprite = null;
                view.image.color = new Color(1f, 0f, 0f, 0.5f); // Red semi-transparent square if no sprite
                view.rectTransform.sizeDelta = new Vector2(64, 64);

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
                var viewScript = view.gameObject.GetComponent<BuildingRuntimeView>();
                if (viewScript != null) viewScript.SetCompleteState();
            } else if (id.StartsWith("villager:")) {
                var vData = snap.villagers.Find(v => v.id == id.Split(':')[1]);
                int vIndex = snap.villagers.IndexOf(vData);
                UnityEngine.Debug.Log($"[VILLAGER_ID_DUMP] index={vIndex} id={vData.id} name={vData.name} visualKey={id}");

                var viewScript = view.gameObject.GetComponent<VillagerRuntimeView>() ?? view.gameObject.AddComponent<VillagerRuntimeView>();
                viewScript.SetState(vData);

                var agent = view.gameObject.GetComponent<VillagerAgentView>() ?? view.gameObject.AddComponent<VillagerAgentView>();
                agent.villagerId = vData.id;
                agent.currentJob = vData.job;
                
                Vector2 targetPos = agent.rectTransform.anchoredPosition;
                UnityEngine.Debug.Log($"[AGENT_POSITION_PRESERVE] villager={vData.id} pos={targetPos.x},{targetPos.y} reason=snapshot_refresh");
                
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

            string animKey = null;
            if (id.StartsWith("villager:")) {
                binder.objectType = "villager";
                var vData = snap.villagers.Find(v => v.id == id.Split(':')[1]);
                if (vData != null) {
                    if (vData.state == "Moving") {
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
                if (view == null || view.gameObject == null) {
                    deadKeys.Add(kvp.Key);
                    continue;
                }
                
                try {
                    var _ = view.transform;
                } catch (MissingReferenceException) {
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
                var go = kvp.Value != null ? kvp.Value.gameObject : null;
                string gName = go != null ? go.name : "null";
                Vector2 pos = kvp.Value != null && kvp.Value.rectTransform != null ? kvp.Value.rectTransform.anchoredPosition : Vector2.zero;
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
