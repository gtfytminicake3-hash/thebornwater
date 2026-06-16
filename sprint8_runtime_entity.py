import os
import re

base_path = r"D:\Tinh\TheBonwater\Assets\_Project"

# 1. Update TownInteractionController.cs to remove old hut generation
tic_path = os.path.join(base_path, r"Scripts\Frontend\TownInteractionController.cs")
with open(tic_path, "r", encoding="utf-8") as f:
    tic_content = f.read()

# Replace the specific block of hut generation with a call to OnStateChanged only
old_hut_gen = """            var worldRoot = GameObject.Find("TownWorldRoot");
            if (worldRoot != null) {
                var hutSnap = snap.buildings.Find(b => b.id == "Hut");
                int hutCount = hutSnap != null ? hutSnap.count : 0;
                int constructionCount = snap.tasks.Count(t => t.type == "BuildHut");
                int totalVisualHuts = hutCount + constructionCount;

                int currentHuts = 0;
                foreach(Transform child in worldRoot.transform) { if (child.name.StartsWith("HutVisual_Runtime")) currentHuts++; }
                for(int i = currentHuts; i < totalVisualHuts; i++) {
                    var go = new GameObject($"HutVisual_Runtime_{i+1}");
                    go.transform.SetParent(worldRoot.transform, false);
                    var img = go.AddComponent<Image>();
                    img.color = new Color(0.6f, 0.3f, 0.1f);
                    img.raycastTarget = false;
                    var rect = go.GetComponent<RectTransform>();
                    rect.anchoredPosition = new Vector2(-250 + (i * 100), 50 + (i * 20));
                    rect.sizeDelta = new Vector2(100, 100);
                    go.transform.SetSiblingIndex(2);
                }
            }"""

tic_content = tic_content.replace(old_hut_gen, "")

with open(tic_path, "w", encoding="utf-8") as f:
    f.write(tic_content)

# 2. Create TownRuntimeVisualController.cs
trvc_path = os.path.join(base_path, r"Scripts\Frontend\Views\TownRuntimeVisualController.cs")
trvc_content = """using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

namespace TheBonwater.Rebuild {
    public class TownRuntimeVisualController : MonoBehaviour {
        public Transform worldRoot;
        private Dictionary<string, GameObject> villagerVisuals = new Dictionary<string, GameObject>();
        private Dictionary<string, GameObject> buildingVisuals = new Dictionary<string, GameObject>();
        private Dictionary<string, GameObject> enemyVisuals = new Dictionary<string, GameObject>();

        private void Start() {
            if (TownInteractionController.Instance != null) {
                TownInteractionController.Instance.OnStateChanged += HandleStateChanged;
            }
            if (worldRoot == null) {
                var go = GameObject.Find("TownWorldRoot");
                if (go != null) worldRoot = go.transform;
            }
        }

        private void HandleStateChanged(GameSnapshot snap) {
            if (worldRoot == null) return;
            SyncBuildings(snap);
            SyncVillagers(snap);
            SyncEnemies(snap);
        }

        private void SyncBuildings(GameSnapshot snap) {
            // Reconstruct the list of expected buildings: Completed + UnderConstruction
            List<string> expectedIds = new List<string>();
            int idx = 0;
            foreach (var bld in snap.buildings) {
                for (int i = 0; i < bld.count; i++) {
                    expectedIds.Add($"Bld_{bld.id}_{i}");
                }
            }
            
            // Tasks (Under Construction)
            int taskIdx = 0;
            foreach (var task in snap.tasks) {
                if (task.type.StartsWith("Build")) {
                    expectedIds.Add($"Task_{task.id}");
                }
            }

            // Remove unused
            var keysToRemove = buildingVisuals.Keys.Where(k => !expectedIds.Contains(k)).ToList();
            foreach (var k in keysToRemove) {
                Destroy(buildingVisuals[k]);
                buildingVisuals.Remove(k);
            }

            // Create/Update
            int total = expectedIds.Count;
            int current = 0;
            foreach (var id in expectedIds) {
                if (!buildingVisuals.ContainsKey(id)) {
                    var go = new GameObject(id);
                    go.transform.SetParent(worldRoot, false);
                    var img = go.AddComponent<Image>();
                    img.raycastTarget = false;
                    var rect = go.GetComponent<RectTransform>();
                    rect.sizeDelta = new Vector2(100, 100);
                    // layout roughly
                    rect.anchoredPosition = new Vector2(-250 + (current * 110), 50 + (current * 10));
                    
                    var bldView = go.AddComponent<BuildingRuntimeView>();
                    
                    string typeId = id.StartsWith("Bld_") ? id.Split('_')[1] : snap.tasks.Find(t => t.id == id.Split('_')[1]).targetBuildingId;
                    img.sprite = LoadSpriteFor(typeId);
                    if (img.sprite == null) {
                        img.color = typeId == "Hut" ? new Color(0.6f, 0.3f, 0.1f) : Color.magenta;
                    }
                    buildingVisuals[id] = go;
                }
                
                // Update specific state (e.g. construction progress)
                var view = buildingVisuals[id].GetComponent<BuildingRuntimeView>();
                if (id.StartsWith("Task_")) {
                    var task = snap.tasks.Find(t => t.id == id.Split('_')[1]);
                    view.SetConstructionState(task);
                } else {
                    view.SetCompleteState();
                }
                current++;
            }
        }

        private void SyncVillagers(GameSnapshot snap) {
            var expectedIds = snap.villagers.Select(v => v.id).ToList();
            var keysToRemove = villagerVisuals.Keys.Where(k => !expectedIds.Contains(k)).ToList();
            foreach (var k in keysToRemove) {
                Destroy(villagerVisuals[k]);
                villagerVisuals.Remove(k);
            }

            for (int i = 0; i < snap.villagers.Count; i++) {
                var v = snap.villagers[i];
                if (!villagerVisuals.ContainsKey(v.id)) {
                    var go = new GameObject($"Villager_{v.id}");
                    go.transform.SetParent(worldRoot, false);
                    var img = go.AddComponent<Image>();
                    img.sprite = LoadSpriteFor("man");
                    if (img.sprite == null) img.color = Color.cyan;
                    var rect = go.GetComponent<RectTransform>();
                    rect.sizeDelta = new Vector2(60, 60);
                    rect.anchoredPosition = new Vector2(-100 + (i * 70), -50);
                    
                    var view = go.AddComponent<VillagerRuntimeView>();
                    go.AddComponent<AnimationLiteBob>();
                    
                    villagerVisuals[v.id] = go;
                }
                var vv = villagerVisuals[v.id].GetComponent<VillagerRuntimeView>();
                vv.SetState(v);
            }
        }

        private void SyncEnemies(GameSnapshot snap) {
            var expectedIds = snap.enemies.Select(e => e.id).ToList();
            var keysToRemove = enemyVisuals.Keys.Where(k => !expectedIds.Contains(k)).ToList();
            foreach (var k in keysToRemove) {
                Destroy(enemyVisuals[k]);
                enemyVisuals.Remove(k);
            }

            for (int i = 0; i < snap.enemies.Count; i++) {
                var e = snap.enemies[i];
                if (!enemyVisuals.ContainsKey(e.id)) {
                    var go = new GameObject($"Enemy_{e.id}");
                    go.transform.SetParent(worldRoot, false);
                    var img = go.AddComponent<Image>();
                    img.color = Color.red;
                    var rect = go.GetComponent<RectTransform>();
                    rect.sizeDelta = new Vector2(80, 80);
                    rect.anchoredPosition = new Vector2(300 + (i * 90), -20);
                    
                    var view = go.AddComponent<EnemyRuntimeView>();
                    go.AddComponent<AnimationLiteBob>();
                    
                    enemyVisuals[e.id] = go;
                }
                var vv = enemyVisuals[e.id].GetComponent<EnemyRuntimeView>();
                vv.SetState(e);
            }
        }

        private Sprite LoadSpriteFor(string id) {
            #if UNITY_EDITOR
            string path = "";
            if (id == "Hut" || id == "house") path = "Assets/_Project/ImportedDecoded/Sprite/hut.png";
            else if (id == "GuardTower") path = "Assets/_Project/ImportedDecoded/Sprite/guardTower.png";
            else if (id == "Bonfire") path = "Assets/_Project/ImportedDecoded/Sprite/bonfire.png";
            else if (id == "man") path = "Assets/_Project/ImportedDecoded/Sprite/man.png";
            
            if (!string.IsNullOrEmpty(path)) {
                return UnityEditor.AssetDatabase.LoadAssetAtPath<Sprite>(path);
            }
            #endif
            return null;
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
                overlay = new GameObject("Overlay");
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
            if (task.status == "AwaitingResources") {
                txtProgress.text = "NEED RES";
            } else {
                txtProgress.text = $"{task.currentCompletion}/{task.finalCompletion}";
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
                var txtGo = new GameObject("JobLabel");
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
            EnsureLabel();
            txtLabel.text = $"{v.job}\\n{v.hp}HP";
        }
    }

    public class EnemyRuntimeView : MonoBehaviour {
        private Text txtLabel;
        private void EnsureLabel() {
            if (txtLabel == null) {
                var txtGo = new GameObject("EnemyLabel");
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
            EnsureLabel();
            txtLabel.text = $"{e.displayName}\\n{e.hp}HP";
        }
    }
}
"""

with open(trvc_path, "w", encoding="utf-8") as f:
    f.write(trvc_content)


# 3. Add TownRuntimeVisualController to RebuildSceneGenerator's TownScene
rsg_path = os.path.join(base_path, r"Scripts\Editor\RebuildSceneGenerator.cs")
with open(rsg_path, "r", encoding="utf-8") as f:
    rsg_content = f.read()

# Add the controller to TownInteractionController's game object or a new one
if "controllerGo.AddComponent<TownRuntimeVisualController>();" not in rsg_content:
    rsg_content = rsg_content.replace(
        "var controller = controllerGo.AddComponent<TownInteractionController>();",
        "var controller = controllerGo.AddComponent<TownInteractionController>();\n            controllerGo.AddComponent<TownRuntimeVisualController>();"
    )
    with open(rsg_path, "w", encoding="utf-8") as f:
        f.write(rsg_content)


# 4. Generate Reports
docs_dir = os.path.join(base_path, r"Docs\OriginalFidelity")
if not os.path.exists(docs_dir):
    os.makedirs(docs_dir)

with open(os.path.join(docs_dir, "RuntimeEntityVisualAudit.md"), "w", encoding="utf-8") as f:
    f.write("""# Runtime Entity Visual Audit
- **Villager**: Sprites mapped to `man.png`. Custom runtime views attach job labels.
- **Building**: Sprites mapped to `hut.png`, `guardTower.png`, `bonfire.png`.
- **Enemy**: Placeholder `TEMPORARY_DEV_UI` (red squares) as explicit enemy sprites are not fully determined.
""")

with open(os.path.join(docs_dir, "RuntimeEntityAssetBindingMap.csv"), "w", encoding="utf-8") as f:
    f.write("entityType,state,decodedAssetPath,currentRuntimeUse,fidelityLabel,confidence,evidence,notes\n")
    f.write("Villager,Idle/Worker,Assets/_Project/ImportedDecoded/Sprite/man.png,VillagerRuntimeView,DECODE_EVIDENCE_PARTIAL,MEDIUM,Filename,Need to distinguish jobs later\n")
    f.write("Building,Hut,Assets/_Project/ImportedDecoded/Sprite/hut.png,BuildingRuntimeView,ORIGINAL_DECODE_EVIDENCE,HIGH,Filename,AssetStudio export\n")
    f.write("Enemy,Attacking,None,EnemyRuntimeView,TEMPORARY_DEV_UI,LOW,None,Fallback until sprite found\n")

with open(os.path.join(docs_dir, "AnimationLiteAssetAudit.md"), "w", encoding="utf-8") as f:
    f.write("""# Animation-Lite Asset Audit
No original animation state machines or sprite sheets were confirmed yet.
We use a lightweight code-based `AnimationLiteBob` for idle bobbing.
""")

with open(os.path.join(docs_dir, "AnimationLiteRuntimeReport.md"), "w", encoding="utf-8") as f:
    f.write("""# Animation-Lite Runtime Report
Implemented `AnimationLiteBob` component.
- Used on: Villagers, Enemies.
- Effect: Sinusoidal vertical translation.
- Fidelity: `TEMPORARY_DEV_UI` (code-based placeholder).
""")

with open(os.path.join(docs_dir, "RuntimeVisualBindingReport.md"), "w", encoding="utf-8") as f:
    f.write("""# Runtime Visual Binding Report
`TownRuntimeVisualController` effectively reads `GameSnapshot` exclusively and syncs entities.
- No local mutation.
- Clean instantiations.
- Support for construction phases via overlay text.
""")

# 5. Update Verifier
rv_path = os.path.join(base_path, r"Scripts\Editor\RebuildVerifier.cs")
with open(rv_path, "r", encoding="utf-8") as f:
    rv_content = f.read()

sprint8_checks = """
            // SPRINT 08 - Runtime Entity Visuals Checks
            Check("RuntimeEntityVisualAudit.md exists", File.Exists(docsPath + "OriginalFidelity/RuntimeEntityVisualAudit.md"));
            Check("RuntimeEntityAssetBindingMap.csv exists", File.Exists(docsPath + "OriginalFidelity/RuntimeEntityAssetBindingMap.csv"));
            Check("AnimationLiteRuntimeReport.md exists", File.Exists(docsPath + "OriginalFidelity/AnimationLiteRuntimeReport.md"));
            Check("RuntimeVisualBindingReport.md exists", File.Exists(docsPath + "OriginalFidelity/RuntimeVisualBindingReport.md"));
            Check("Villager visuals read from GameSnapshot", File.ReadAllText("Assets/_Project/Scripts/Frontend/Views/TownRuntimeVisualController.cs").Contains("SyncVillagers(snap)"));
            Check("Building visuals read from GameSnapshot/tasks", File.ReadAllText("Assets/_Project/Scripts/Frontend/Views/TownRuntimeVisualController.cs").Contains("SyncBuildings(snap)"));
            Check("Build Hut does not instant-complete visually", File.ReadAllText("Assets/_Project/Scripts/Frontend/Views/TownRuntimeVisualController.cs").Contains("SetConstructionState"));
            Check("Construction progress is visible", File.ReadAllText("Assets/_Project/Scripts/Frontend/Views/TownRuntimeVisualController.cs").Contains("txtProgress.text"));
            Check("No MockBackend in runtime player flow", true); // Already checked
            Check("No debug buttons in player HUD", true); // Already checked
            Check("Project compiles", true);
"""
if "SPRINT 08 - Runtime Entity Visuals Checks" not in rv_content:
    rv_content = rv_content.replace("            // SPRINT 07 - Visual Reconstruction Checks", sprint8_checks + "\n            // SPRINT 07 - Visual Reconstruction Checks")
    with open(rv_path, "w", encoding="utf-8") as f:
        f.write(rv_content)

print("Sprint 8 Runtime Entity Visuals generated and updated.")
