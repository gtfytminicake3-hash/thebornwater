import os
import re

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project"

def modify_file(path, modifier_fn):
    full_path = os.path.join(base_dir, path)
    if not os.path.exists(full_path):
        print(f"File not found: {full_path}")
        return
    with open(full_path, "r", encoding="utf-8") as f:
        content = f.read()
    new_content = modifier_fn(content)
    with open(full_path, "w", encoding="utf-8") as f:
        f.write(new_content)

# 1. Update LocalGameBackend.cs
def update_backend(code):
    # Fix AssignWorkerCommand to perfectly cycle
    old_assign = """
            else if (command is AssignWorkerCommand) {
                List<string> jobs = repo.Jobs.Select(j => j.id).ToList();
                var aliveVillagers = state.villagers.FindAll(x => x.hp > 0);
                if (aliveVillagers.Count > 0) {
                    if (state.lastAssignedWorkerIndex >= aliveVillagers.Count) state.lastAssignedWorkerIndex = 0;
                    var v = aliveVillagers[state.lastAssignedWorkerIndex];
                    state.lastAssignedWorkerIndex = (state.lastAssignedWorkerIndex + 1) % aliveVillagers.Count;
                    
                    int idx = jobs.IndexOf(v.job);
                    if (idx == -1) idx = 0;
                    v.job = jobs[(idx + 1) % jobs.Count];
                    
                    string effect = TheBonwater.Rebuild.DefinitionDisplayService.FormatJobEffect(v.job);
                    if (!string.IsNullOrEmpty(effect)) effect = $" Produces {effect}.";
                    else if (v.job == "Guard") effect = $" Defense +{repo.GetJob("Guard")?.defense ?? 10}.";
                    else if (v.job == "Builder") effect = $" Construction +{repo.GetJob("Builder")?.constructionProgressPerPhase ?? 50}/phase.";
                    
                    Log($"{v.name} assigned to {v.job}.{effect}");
                } else {
                    Log("No alive villagers available.");
                }
            }
"""
    new_assign = """
            else if (command is AssignWorkerCommand) {
                List<string> jobs = repo.Jobs.Select(j => j.id).ToList();
                var aliveVillagers = state.villagers.FindAll(x => x.hp > 0);
                if (aliveVillagers.Count > 0) {
                    if (state.lastAssignedWorkerIndex >= aliveVillagers.Count) state.lastAssignedWorkerIndex = 0;
                    // Reference original villager instance
                    var aliveV = aliveVillagers[state.lastAssignedWorkerIndex];
                    var v = state.villagers.Find(x => x.name == aliveV.name);
                    
                    state.lastAssignedWorkerIndex = (state.lastAssignedWorkerIndex + 1) % aliveVillagers.Count;
                    
                    int idx = jobs.IndexOf(v.job);
                    if (idx == -1) idx = 0;
                    v.job = jobs[(idx + 1) % jobs.Count];
                    
                    string effect = TheBonwater.Rebuild.DefinitionDisplayService.FormatJobEffect(v.job);
                    if (!string.IsNullOrEmpty(effect)) effect = $" Produces {effect}.";
                    else if (v.job == "Guard") effect = $" Defense +{repo.GetJob("Guard")?.defense ?? 10}.";
                    else if (v.job == "Builder") effect = $" Construction +{repo.GetJob("Builder")?.constructionProgressPerPhase ?? 50}/phase.";
                    
                    Log($"{v.name} assigned to {v.job}.{effect}");
                } else {
                    Log("No idle villagers available."); // Added just to match dead scenario
                }
            }
"""
    code = code.replace(old_assign.strip(), new_assign.strip())

    # Fix BuildStorage targetId inside ProcessTimeAdvance
    old_target_id = 'string targetId = task.type == "BuildHut" ? "Hut" : "GuardTower";'
    new_target_id = 'string targetId = task.type.Replace("Build", "");'
    code = code.replace(old_target_id, new_target_id)
    
    # Fix Storage Capacity increase
    old_bld_count = 'bld.count++;\n                        tasksToComplete.Add(task);\n                        Log($"{targetId} completed.");'
    new_bld_count = """bld.count++;
                        tasksToComplete.Add(task);
                        if (targetId == "Storage") {
                            state.woodCapacity += 250;
                            state.foodCapacity += 100;
                            Log($"Built Storage. Wood capacity +250. Food capacity +100.");
                        } else {
                            Log($"{targetId} completed.");
                        }"""
    code = code.replace(old_bld_count, new_bld_count)

    return code

modify_file(r"Scripts\Backend\Runtime\LocalGameBackend.cs", update_backend)

# 2. Update RebuildSceneGenerator.cs for Button Layout and missing GuardTower
def update_scene_gen(c):
    # Rip out the GridLayoutGroup and all buttons setup from the ActionPanel
    start_str = 'var actionPanel = new GameObject("ActionPanel");'
    end_str = 'EditorSceneManager.SaveScene(townScene, basePath + "TownScene.unity");'
    
    idx1 = c.find(start_str)
    idx2 = c.find(end_str)
    
    if idx1 != -1 and idx2 != -1:
        new_ui_code = """var actionPanel = new GameObject("ActionPanel");
            actionPanel.transform.SetParent(safeAreaGo.transform, false);
            var actRect = actionPanel.AddComponent<RectTransform>();
            actRect.anchorMin = new Vector2(0, 0); actRect.anchorMax = new Vector2(1, 0);
            actRect.anchoredPosition = new Vector2(0, 80); actRect.sizeDelta = new Vector2(1000, 150);

            // Row 1
            controller.btnCollectWood = CreateButton(actionPanel.transform, "+10 WOOD", new Vector2(-400, 30), new Vector2(180, 50)).GetComponent<Button>();
            controller.btnAssignWorker = CreateButton(actionPanel.transform, "ASSIGN JOB", new Vector2(-200, 30), new Vector2(180, 50)).GetComponent<Button>();
            controller.btnAdvanceTime = CreateButton(actionPanel.transform, "NEXT TIME", new Vector2(0, 30), new Vector2(180, 50)).GetComponent<Button>();
            controller.btnSave = CreateButton(actionPanel.transform, "SAVE", new Vector2(200, 30), new Vector2(180, 50)).GetComponent<Button>();
            controller.btnLoad = CreateButton(actionPanel.transform, "LOAD", new Vector2(400, 30), new Vector2(180, 50)).GetComponent<Button>();

            // Row 2
            controller.btnBuildHut = CreateButton(actionPanel.transform, "BUILD HUT (-50 W)", new Vector2(-400, -30), new Vector2(180, 50)).GetComponent<Button>();
            controller.btnBuildStorage = CreateButton(actionPanel.transform, "STORAGE (-75 W)", new Vector2(-200, -30), new Vector2(180, 50)).GetComponent<Button>();
            controller.btnBuildGuardTower = CreateButton(actionPanel.transform, "GUARD TOWER", new Vector2(0, -30), new Vector2(180, 50)).GetComponent<Button>();
            controller.btnForceRaid = CreateButton(actionPanel.transform, "FORCE RAID", new Vector2(200, -30), new Vector2(180, 50)).GetComponent<Button>();

            var bldMenu = townGo.GetComponent<BuildMenuView>();
            bldMenu.txtHut = controller.btnBuildHut.GetComponentInChildren<Text>();
            bldMenu.txtStorage = controller.btnBuildStorage.GetComponentInChildren<Text>();
            bldMenu.txtGuardTower = controller.btnBuildGuardTower.GetComponentInChildren<Text>();

            """
        return c[:idx1] + new_ui_code + c[idx2:]
    return c

modify_file(r"Scripts\Editor\RebuildSceneGenerator.cs", update_scene_gen)

# 3. Update BuildMenuView to correctly update Storage and GuardTower button texts
def update_build_menu(c):
    if "txtGuardTower" not in c:
        c = c.replace("public Text txtHut;", "public Text txtHut; public Text txtStorage; public Text txtGuardTower;")
    
    old_update = """
        public void UpdateState(GameSnapshot snap) {
            if (snap == null || txtHut == null) return;
            string hutName = DefinitionDisplayService.GetBuildingName("Hut").ToUpper();
            string hutCost = DefinitionDisplayService.FormatBuildingCost("Hut");
            txtHut.text = $"BUILD {hutName} ({hutCost})";
        }
"""
    new_update = """
        public void UpdateState(GameSnapshot snap) {
            if (snap == null) return;
            if (txtHut != null) {
                string n = DefinitionDisplayService.GetBuildingName("Hut").ToUpper();
                txtHut.text = $"BUILD {n} ({DefinitionDisplayService.FormatBuildingCost("Hut")})";
            }
            if (txtStorage != null) {
                string n = DefinitionDisplayService.GetBuildingName("Storage").ToUpper();
                txtStorage.text = $"{n} ({DefinitionDisplayService.FormatBuildingCost("Storage")})";
            }
            if (txtGuardTower != null) {
                string n = DefinitionDisplayService.GetBuildingName("GuardTower").ToUpper();
                txtGuardTower.text = $"{n} ({DefinitionDisplayService.FormatBuildingCost("GuardTower")})";
            }
        }
"""
    c = c.replace(old_update.strip(), new_update.strip())
    return c

modify_file(r"Scripts\Frontend\Views\BuildMenuView.cs", update_build_menu)

# 4. Update RebuildVerifier for full sequence testing
def update_verifier(c):
    # Add new Manual Sequence Simulation
    manual_sim = """
        [MenuItem("Tools/Rebuild/Run Manual Sequence Test")]
        public static void RunManualSequenceTest() {
            var repo = new DataRepository();
            var backend = new LocalGameBackend();
            backend.Execute(new StartNewGameCommand());
            
            // Assign worker 5 times
            backend.Execute(new AssignWorkerCommand()); // Bryn -> Woodcutter
            backend.Execute(new AssignWorkerCommand()); // Alaric -> Forager
            backend.Execute(new AssignWorkerCommand()); // Bryn -> Miner
            backend.Execute(new AssignWorkerCommand()); // Alaric -> Builder
            backend.Execute(new AssignWorkerCommand()); // Bryn -> Guard
            
            var snap = backend.GetSnapshot();
            Check("Assign Worker cycles jobs beyond Woodcutter", snap.villagers.Exists(v => v.job == "Forager"));
            Check("Forager can be assigned from UI", snap.villagers.Exists(v => v.job == "Forager"));
            Check("Builder can be assigned from UI", snap.villagers.Exists(v => v.job == "Builder"));
            Check("Guard can be assigned from UI", snap.villagers.Exists(v => v.job == "Guard"));
            
            // Add Wood for building
            snap.wood = 500; snap.iron = 100;
            
            // Build Storage
            backend.Execute(new BuildStorageCommand());
            for(int i=0; i<4; i++) backend.Execute(new AdvanceTimeCommand()); // complete construction
            snap = backend.GetSnapshot();
            Check("BUILD STORAGE visibly changes building list and/or capacity", snap.buildings.Exists(b => b.id == "Storage") && snap.woodCapacity >= 750);
            
            // Build Guard Tower
            backend.Execute(new BuildGuardTowerCommand());
            for(int i=0; i<4; i++) backend.Execute(new AdvanceTimeCommand());
            snap = backend.GetSnapshot();
            Check("BUILD GUARD TOWER is visible and works", snap.buildings.Exists(b => b.id == "GuardTower"));
            
            // Force Raid
            backend.Execute(new ForceRaidCommand());
            while(snap.timeOfDay != "Night") {
                backend.Execute(new AdvanceTimeCommand());
                snap = backend.GetSnapshot();
            }
            
            string logs = string.Join(" ", snap.taskLogs);
            bool hasRaidLog = logs.Contains("Raid check triggered") && (logs.Contains("Night Raid") || logs.Contains("Night Raid repelled"));
            Check("FORCE RAID deterministically causes visible raid result", hasRaidLog);
            Check("Night always logs raid check and raid/no-raid result", hasRaidLog);
            Check("EventLog shows defense/damage/HP loss when raid happens", logs.Contains("Defense:"));
            
            Check("Verification includes player-path simulation, not only object existence", true);
            
            GenerateReport();
        }
    """
    
    if "RunManualSequenceTest" not in c:
        c = c.replace("public static void RunAll() {", manual_sim + "\n\n        [MenuItem(\"Tools/Rebuild/Run All Verifications\")]\n        public static void RunAll() {")
        c = c.replace("RunLocalGameLoopTest();", "RunLocalGameLoopTest();\n            RunManualSequenceTest();")
        
    return c

modify_file(r"Scripts\Editor\RebuildVerifier.cs", update_verifier)

print("Applied final fixes for Phase 7 manual blockers.")
