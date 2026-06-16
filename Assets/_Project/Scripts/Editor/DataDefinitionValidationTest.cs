using UnityEngine;
using UnityEditor;
using TheBonwater.Rebuild.Data;

namespace TheBonwater.Rebuild.Editor
{
    public class DataDefinitionValidationTest : EditorWindow
    {
        [MenuItem("Tools/TheBonwater/Run Data Definition Validation Test")]
        public static void Run()
        {
            global::UnityEngine.Debug.Log("==== STARTING DATA DEFINITION VALIDATION ====");
            
            var repo = new DataRepository();
            repo.LoadAll();
            
            bool hasErrors = false;
            
            void AssertTrue(bool condition, string successMsg, string errorMsg) {
                if (!condition) {
                    global::UnityEngine.Debug.LogError("[FAIL] " + errorMsg);
                    hasErrors = true;
                } else {
                    global::UnityEngine.Debug.Log("[PASS] " + successMsg);
                }
            }

            // 1-8. JSON parse
            AssertTrue(repo.AssetMap != null, "asset_map.json parsed", "asset_map.json failed to parse");
            AssertTrue(repo.AnimationMap != null, "animation_map.json parsed", "animation_map.json failed to parse");
            AssertTrue(repo.Buildings != null && repo.Buildings.Count > 0, "buildings.json parsed", "buildings.json failed to parse");
            AssertTrue(repo.Jobs != null && repo.Jobs.Count > 0, "jobs.json parsed", "jobs.json failed to parse");
            AssertTrue(repo.Resources != null, "resources.json parsed", "resources.json failed to parse");
            AssertTrue(repo.Enemies != null, "monsters.json parsed", "monsters.json failed to parse");
            AssertTrue(repo.WorldObjects != null, "world_objects.json parsed", "world_objects.json failed to parse");
            AssertTrue(repo.BuildMenu != null && repo.BuildMenu.menuItems.Count > 0, "ui_build_menu.json parsed", "ui_build_menu.json failed to parse");

            // 9. Required building IDs
            AssertTrue(repo.GetBuilding("hut") != null, "hut exists", "hut building missing");
            AssertTrue(repo.GetBuilding("storage") != null, "storage exists", "storage building missing");
            AssertTrue(repo.GetBuilding("guardTower") != null, "guardTower exists", "guardTower building missing");

            // 10. Bonfire exists
            bool hasBonfire = repo.GetBuilding("bonfire") != null || (repo.WorldObjects != null && repo.WorldObjects.objects.Exists(o => o.id.ToLower() == "bonfire"));
            AssertTrue(hasBonfire, "bonfire exists in definitions", "bonfire missing in both buildings and world_objects");

            // 11. Build menu item ids
            if (repo.BuildMenu != null) {
                foreach(var item in repo.BuildMenu.menuItems) {
                    AssertTrue(!string.IsNullOrEmpty(item.buildingId), $"Build menu item {item.id} has buildingId", $"Build menu item {item.id} missing buildingId");
                    AssertTrue(repo.GetBuilding(item.buildingId) != null, $"Build menu target {item.buildingId} exists", $"Build menu target {item.buildingId} missing in buildings");
                    
                    bool hasBuildPrefix = item.buildingId.StartsWith("Build", System.StringComparison.OrdinalIgnoreCase);
                    AssertTrue(!hasBuildPrefix, $"buildingId {item.buildingId} does not start with Build", $"buildingId {item.buildingId} must not contain command prefix");
                    
                    // Specific id checks
                    if (item.id.Equals("Hut", System.StringComparison.OrdinalIgnoreCase)) {
                        AssertTrue(item.buildingId == "hut", "Hut menu item maps to canonical id hut", $"Hut maps to {item.buildingId}");
                    }
                    if (item.id.Equals("Storage", System.StringComparison.OrdinalIgnoreCase)) {
                        AssertTrue(item.buildingId == "storage", "Storage menu item maps to canonical id storage", $"Storage maps to {item.buildingId}");
                    }
                    if (item.id.Equals("GuardTower", System.StringComparison.OrdinalIgnoreCase)) {
                        AssertTrue(item.buildingId == "guardTower", "GuardTower menu item maps to canonical id guardTower", $"GuardTower maps to {item.buildingId}");
                    }
                }
            }

            // 12. Asset keys resolve
            var requiredAssets = new string[] { "bonfire", "hut", "storage", "guardTower", "villagerMale", "wood", "build3", "hammer" };
            if (repo.AssetMap != null && repo.AssetMap.assets != null) {
                foreach(var req in requiredAssets) {
                    bool found = repo.AssetMap.assets.ContainsKey(req) || repo.AssetMap.assets.ContainsKey(req.ToLower()) || repo.AssetMap.assets.ContainsKey(req.Substring(0,1).ToUpper() + req.Substring(1));
                    AssertTrue(found, $"Asset map contains {req}", $"Asset map missing {req}");
                }
            }

            // 13. Animation keys resolve
            var requiredAnims = new string[] { "villager_idle", "villager_walk", "villager_build", "villager_work", "monster_idle", "monster_attack" };
            if (repo.AnimationMap != null && repo.AnimationMap.animations != null) {
                foreach(var req in requiredAnims) {
                    bool found = repo.AnimationMap.animations.ContainsKey(req);
                    AssertTrue(found, $"Animation map contains {req}", $"Animation map missing {req}");
                    if (found) {
                        string val = repo.AnimationMap.animations[req];
                        if (val == "UNKNOWN/FALLBACK") {
                            global::UnityEngine.Debug.LogWarning($"[WARN] Animation {req} is marked as UNKNOWN/FALLBACK.");
                        }
                    }
                }
            }

            // 14. Duplicates
            var allIds = new System.Collections.Generic.HashSet<string>();
            bool hasDupes = false;
            foreach(var b in repo.Buildings) {
                if (!allIds.Add(b.id.ToLower())) {
                    global::UnityEngine.Debug.LogError("[FAIL] Duplicate canonical ID: " + b.id);
                    hasDupes = true;
                }
            }
            AssertTrue(!hasDupes, "No duplicate IDs", "Duplicate canonical IDs found");

            if (!hasErrors) {
                global::UnityEngine.Debug.Log("==== DATA DEFINITION VALIDATION COMPLETED SUCCESSFULLY ====");
            } else {
                global::UnityEngine.Debug.LogError("==== DATA DEFINITION VALIDATION FAILED ====");
            }
        }
    }
}


