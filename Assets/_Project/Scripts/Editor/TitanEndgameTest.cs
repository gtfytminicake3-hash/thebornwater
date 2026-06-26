using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using TheBonwater.Rebuild.Backend.Runtime;
using TheBonwater.Rebuild;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine.UI;

namespace TheBonwater.Rebuild.Editor
{
    public class TitanEndgameTest
    {
        [MenuItem("Tools/TheBonwater/Run Titan Endgame Tests")]
        public static void Run()
        {
            EnsureSceneOwnedUIPanels.Execute();
            int pass = 0;
            int fail = 0;
            var report = new System.Text.StringBuilder();
            report.AppendLine("# Titan/Endgame Test Report");
            report.AppendLine();

            void Check(string name, bool condition)
            {
                if (condition)
                {
                    pass++;
                    report.AppendLine($"- [PASS] {name}");
                }
                else
                {
                    fail++;
                    report.AppendLine($"- [FAIL] {name}");
                    UnityEngine.Debug.LogError($"[TitanEndgameTest Fail] {name}");
                }
            }

            string realSavePath = Path.Combine(UnityEngine.Application.persistentDataPath, "local_runtime_save.json");
            string globalBackupPath = realSavePath + ".globalbak";
            bool globalBackedUp = false;
            if (File.Exists(realSavePath))
            {
                try
                {
                    File.Copy(realSavePath, globalBackupPath, true);
                    File.Delete(realSavePath);
                    globalBackedUp = true;
                }
                catch {}
            }

            try
            {
                // Check BOSS.png asset
                string bossAssetPath = "Assets/_Project/ImportedDecoded/Sprite/BOSS.png";
                Check("BOSS.png asset exists on disk", File.Exists(bossAssetPath));
                Sprite bossSp = AssetDatabase.LoadAssetAtPath<Sprite>(bossAssetPath);
                Check("BOSS.png loaded successfully as Sprite", bossSp != null);

            // Group 1: New game TitanState initializes
            {
                var snap = new GameSnapshot();
                Check("1a. TitanState initializes not null", snap.titanState != null);
                if (snap.titanState != null)
                {
                    Check("1b. TitanState starts not awakened", !snap.titanState.isAwakened);
                    Check("1c. TitanState starts not defeated", !snap.titanState.isDefeated);
                    Check("1d. TitanState HP starts at 500", snap.titanState.hp == 500);
                    Check("1e. TitanState max HP starts at 500", snap.titanState.maxHp == 500);
                }
            }

            // Group 2: Old save sanitization
            {
                var backend = new LocalGameBackend();
                var stateField = typeof(LocalGameBackend).GetField("state", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                var sanitizeMethod = typeof(LocalGameBackend).GetMethod("SanitizeLoadedState", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var testState = new GameSnapshot();
                testState.titanState = null; // old save

                stateField.SetValue(backend, testState);
                sanitizeMethod.Invoke(backend, null);

                var sanitizedState = (GameSnapshot)stateField.GetValue(backend);
                Check("2a. Old save null titanState repaired", sanitizedState.titanState != null);
                if (sanitizedState.titanState != null)
                {
                    Check("2b. Repaired maxHp is 500", sanitizedState.titanState.maxHp == 500);
                    Check("2c. Repaired hp is 500", sanitizedState.titanState.hp == 500);
                }

                // Invalid HP/maxHP repairs
                testState.titanState = new TitanState { hp = 600, maxHp = 0, isDefeated = false };
                stateField.SetValue(backend, testState);
                sanitizeMethod.Invoke(backend, null);
                sanitizedState = (GameSnapshot)stateField.GetValue(backend);
                Check("2d. Invalid maxHp repaired to 500", sanitizedState.titanState.maxHp == 500);
                Check("2e. Hp clamped to maxHp", sanitizedState.titanState.hp == 500);

                testState.titanState = new TitanState { hp = -50, maxHp = 500, isDefeated = false };
                stateField.SetValue(backend, testState);
                sanitizeMethod.Invoke(backend, null);
                sanitizedState = (GameSnapshot)stateField.GetValue(backend);
                Check("2f. Negative Hp clamped to 0", sanitizedState.titanState.hp == 0);

                testState.titanState = new TitanState { hp = 300, maxHp = 500, isDefeated = true };
                stateField.SetValue(backend, testState);
                sanitizeMethod.Invoke(backend, null);
                sanitizedState = (GameSnapshot)stateField.GetValue(backend);
                Check("2g. If defeated, hp must be 0", sanitizedState.titanState.hp == 0);
            }

            // Group 3: finalCastle discovery awakens Titan
            {
                var backend = new LocalGameBackend();
                var stateField = typeof(LocalGameBackend).GetField("state", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                var checkObjectivesMethod = typeof(LocalGameBackend).GetMethod("CheckObjectives", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var testState = new GameSnapshot();
                testState.villagers.Add(new VillagerSnapshot { id = "v1", hp = 100, job = "Builder" });
                testState.worldMapState.locations.Add(new WorldMapLocationState { id = "finalCastle", isDiscovered = false });
                testState.titanState = new TitanState { isAwakened = false, hp = 500 };

                stateField.SetValue(backend, testState);
                checkObjectivesMethod.Invoke(backend, null);

                var updatedState = (GameSnapshot)stateField.GetValue(backend);
                Check("3a. Not awakened if finalCastle not discovered", !updatedState.titanState.isAwakened);

                // Discover castle
                testState.worldMapState.locations[0].isDiscovered = true;
                checkObjectivesMethod.Invoke(backend, null);
                updatedState = (GameSnapshot)stateField.GetValue(backend);

                Check("3b. Awakened when finalCastle discovered", updatedState.titanState.isAwakened);
                Check("3c. Objective text updated for Titan", updatedState.objectiveText == "Endgame: Defeat the Fallen Titan at the Castle.");
            }

            // Group 4: No duplicate awaken reset
            {
                var backend = new LocalGameBackend();
                var stateField = typeof(LocalGameBackend).GetField("state", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                var checkObjectivesMethod = typeof(LocalGameBackend).GetMethod("CheckObjectives", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var testState = new GameSnapshot();
                testState.villagers.Add(new VillagerSnapshot { id = "v1", hp = 100, job = "Builder" });
                testState.worldMapState.locations.Add(new WorldMapLocationState { id = "finalCastle", isDiscovered = true });
                testState.titanState = new TitanState { isAwakened = true, hp = 350 }; // already damaged

                stateField.SetValue(backend, testState);
                checkObjectivesMethod.Invoke(backend, null);

                var updatedState = (GameSnapshot)stateField.GetValue(backend);
                Check("4. HP not reset to 500 on duplicate awaken check", updatedState.titanState.hp == 350);
            }

            // Group 5: Attack validation
            {
                var backend = new LocalGameBackend();
                var stateField = typeof(LocalGameBackend).GetField("state", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                // 5a. cannot attack if Titan not awakened
                var testState = new GameSnapshot();
                testState.titanState = new TitanState { isAwakened = false, hp = 500 };
                testState.villagers.Add(new VillagerSnapshot { id = "v1", job = "Guard", hp = 100, isOnExpedition = false });
                stateField.SetValue(backend, testState);

                var cmd = new AttackTitanCommand { attackerVillagerIds = new List<string> { "v1" } };
                var res = backend.Execute(cmd);
                Check("5a. Cannot attack if not awakened", !res.success);

                // 5b. cannot attack if no attackers
                testState.titanState.isAwakened = true;
                cmd.attackerVillagerIds = new List<string>();
                res = backend.Execute(cmd);
                Check("5b. Cannot attack with empty attacker list", !res.success);

                // 5c. invalid attacker IDs rejected safely
                cmd.attackerVillagerIds = new List<string> { "invalid_id" };
                res = backend.Execute(cmd);
                Check("5c. Invalid attacker ID rejected", !res.success);

                // 5d. dead villagers rejected safely
                testState.villagers.Add(new VillagerSnapshot { id = "v2", job = "Guard", hp = 0, isOnExpedition = false });
                cmd.attackerVillagerIds = new List<string> { "v2" };
                res = backend.Execute(cmd);
                Check("5d. Dead attacker rejected", !res.success);

                // 5e. away villagers rejected safely
                testState.villagers.Add(new VillagerSnapshot { id = "v3", job = "Guard", hp = 100, isOnExpedition = true });
                cmd.attackerVillagerIds = new List<string> { "v3" };
                res = backend.Execute(cmd);
                Check("5e. Attacker on expedition rejected", !res.success);

                // 5f. non-guard villagers rejected safely
                testState.villagers.Add(new VillagerSnapshot { id = "v4", job = "Builder", hp = 100, isOnExpedition = false });
                cmd.attackerVillagerIds = new List<string> { "v4" };
                res = backend.Execute(cmd);
                Check("5f. Non-guard attacker rejected", !res.success);
            }

            // Group 6: Attack with valid guard damages Titan
            {
                var backend = new LocalGameBackend();
                var stateField = typeof(LocalGameBackend).GetField("state", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var testState = new GameSnapshot();
                testState.titanState = new TitanState { isAwakened = true, hp = 500, maxHp = 500 };
                testState.villagers.Add(new VillagerSnapshot { id = "v1", job = "Guard", hp = 100 });
                stateField.SetValue(backend, testState);

                var cmd = new AttackTitanCommand { attackerVillagerIds = new List<string> { "v1" } };
                var res = backend.Execute(cmd);

                var updatedState = backend.GetSnapshot();
                Check("6a. Attack success", res.success);
                Check("6b. Titan HP decreases", updatedState.titanState.hp < 500);
                Check("6c. Battle log/result updates", !string.IsNullOrEmpty(updatedState.titanState.lastBattleResult));
            }

            // Group 7: Titan return damage
            {
                var backend = new LocalGameBackend();
                var stateField = typeof(LocalGameBackend).GetField("state", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var testState = new GameSnapshot();
                testState.titanState = new TitanState { isAwakened = true, hp = 500, maxHp = 500 };
                testState.villagers.Add(new VillagerSnapshot { id = "v1", job = "Guard", hp = 5 });
                stateField.SetValue(backend, testState);

                var cmd = new AttackTitanCommand { attackerVillagerIds = new List<string> { "v1" } };
                backend.Execute(cmd);

                var updatedState = backend.GetSnapshot();
                var guard = updatedState.villagers.First(x => x.id == "v1");
                Check("7a. Attacker received damage", guard.hp < 5);
                Check("7b. Attacker health clamped to 0, no negative health", guard.hp >= 0);
            }

            // Group 8: Titan defeated
            {
                var backend = new LocalGameBackend();
                var stateField = typeof(LocalGameBackend).GetField("state", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var testState = new GameSnapshot();
                testState.titanState = new TitanState { isAwakened = true, hp = 1, maxHp = 500 };
                testState.villagers.Add(new VillagerSnapshot { id = "v1", job = "Guard", hp = 100 });
                stateField.SetValue(backend, testState);

                var cmd = new AttackTitanCommand { attackerVillagerIds = new List<string> { "v1" } };
                backend.Execute(cmd);

                var updatedState = backend.GetSnapshot();
                Check("8a. Titan hp is 0", updatedState.titanState.hp == 0);
                Check("8b. Titan isDefeated set to true", updatedState.titanState.isDefeated);
                Check("8c. endgameVictoryAchieved set to true", updatedState.titanState.endgameVictoryAchieved);
                Check("8d. Game isGameOver is true", updatedState.isGameOver);
                Check("8e. gameStatus set to Victory", updatedState.gameStatus == "Victory");
            }

            // Group 9: Save/load persistence
            {
                string gp9SavePath = realSavePath;
                string backupPath = gp9SavePath + ".bak";
                bool backedUp = false;
                if (File.Exists(gp9SavePath))
                {
                    File.Copy(gp9SavePath, backupPath, true);
                    backedUp = true;
                }

                try
                {
                    var backend = new LocalGameBackend();
                    var stateField = typeof(LocalGameBackend).GetField("state", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    
                    var testState = new GameSnapshot();
                    testState.titanState = new TitanState { isAwakened = true, hp = 250, maxHp = 500, isDefeated = false, endgameVictoryAchieved = false };
                    
                    stateField.SetValue(backend, testState);
                    backend.Execute(new SaveGameCommand());

                    var loadedBackend = new LocalGameBackend();
                    var loadedState = loadedBackend.GetSnapshot();

                    Check("9a. Awakened state persisted", loadedState.titanState.isAwakened);
                    Check("9b. Damaged HP persisted", loadedState.titanState.hp == 250);
                    Check("9c. Defeated state persisted", !loadedState.titanState.isDefeated);
                }
                finally
                {
                    if (File.Exists(gp9SavePath))
                    {
                        File.Delete(gp9SavePath);
                    }
                    if (backedUp && File.Exists(backupPath))
                    {
                        File.Copy(backupPath, gp9SavePath);
                        File.Delete(backupPath);
                    }
                }
            }

            // Group 10: UI scene-owned
            {
                bool isBatch = Application.isBatchMode;
                if (isBatch)
                {
                    try {
                        UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/_Project/Scenes/TownScene.unity");
                    } catch {}
                }

                var hudRoot = GameObject.Find("HUDRoot");
                Check("10a. HUDRoot exists in TownScene", hudRoot != null);
                if (hudRoot != null)
                {
                    var titanPanel = hudRoot.transform.Find("TitanBossPanel");
                    Check("10b. TitanBossPanel exists under HUDRoot", titanPanel != null);
                    if (titanPanel != null)
                    {
                        Check("10c. TitleText exists", titanPanel.transform.Find("TitleText") != null);
                        Check("10d. StatusText exists", titanPanel.transform.Find("StatusText") != null);
                        Check("10e. HpText exists", titanPanel.transform.Find("HpText") != null);
                        Check("10f. HpSlider exists", titanPanel.transform.Find("HpSlider") != null);
                        Check("10g. BtnAttackTitan exists", titanPanel.transform.Find("BtnAttackTitan") != null);
                        Check("10h. TitanBossPanelView component attached", titanPanel.GetComponent<TitanBossPanelView>() != null);
                        Check("10k. ExplanationText exists", titanPanel.transform.Find("ExplanationText") != null);
                        Check("10l. TitanAvatar exists", titanPanel.transform.Find("TitanAvatar") != null);

                        var titanView = titanPanel.GetComponent<TitanBossPanelView>();
                        if (titanView != null)
                        {
                            Check("10m. explanationText is bound on TitanBossPanelView", titanView.explanationText != null);
                            Check("10n. titanAvatar is bound on TitanBossPanelView", titanView.titanAvatar != null);
                            Check("10o. TitanAvatarImage exists under TitanAvatar", titanPanel.Find("TitanAvatar/TitanAvatarImage") != null);
                            Check("10p. titanAvatarImage is bound on TitanBossPanelView", titanView.titanAvatarImage != null);
                            Check("10q. titanAvatarImage sprite is assigned to BOSS", titanView.titanAvatarImage.sprite != null && titanView.titanAvatarImage.sprite.name.StartsWith("BOSS"));
                        }
                    }

                    var uiManager = hudRoot.GetComponent<GameplayUIManager>();
                    Check("10i. GameplayUIManager exists on HUDRoot", uiManager != null);
                    if (uiManager != null)
                    {
                        Check("10j. TitanBossPanelView is bound on GameplayUIManager", uiManager.titanBossPanelView != null);
                    }
                }
            }

            // Group 11: TitanBossPanelView display
            {
                var go = new GameObject("TestTitanView");
                var view = go.AddComponent<TitanBossPanelView>();

                var titleGo = new GameObject("TitleText");
                titleGo.transform.SetParent(go.transform);
                view.titleText = titleGo.AddComponent<Text>();

                var statusGo = new GameObject("StatusText");
                statusGo.transform.SetParent(go.transform);
                view.statusText = statusGo.AddComponent<Text>();

                var hpGo = new GameObject("HpText");
                hpGo.transform.SetParent(go.transform);
                view.hpText = hpGo.AddComponent<Text>();

                var sliderGo = new GameObject("HpSlider");
                sliderGo.transform.SetParent(go.transform);
                view.hpSlider = sliderGo.AddComponent<Slider>();

                var btnGo = new GameObject("BtnAttackTitan");
                btnGo.transform.SetParent(go.transform);
                view.btnAttackTitan = btnGo.AddComponent<Button>();

                var expGo = new GameObject("ExplanationText");
                expGo.transform.SetParent(go.transform);
                view.explanationText = expGo.AddComponent<Text>();

                var avatarGo = new GameObject("TitanAvatar");
                avatarGo.transform.SetParent(go.transform);
                view.titanAvatar = avatarGo;

                var avatarImgGo = new GameObject("TitanAvatarImage");
                avatarImgGo.transform.SetParent(avatarGo.transform);
                view.titanAvatarImage = avatarImgGo.AddComponent<Image>();

                // 11a. Hidden before awaken
                var snap = new GameSnapshot();
                snap.titanState = new TitanState { isAwakened = false };
                view.RenderState(snap);
                Check("11a. Panel hidden before awaken", !go.activeSelf);

                // 11b. Visible after awaken
                snap.titanState = new TitanState { isAwakened = true, hp = 400, maxHp = 500 };
                view.RenderState(snap);
                Check("11b. Panel visible after awaken", go.activeSelf);
                Check("11c. HP text updates correctly", view.hpText.text == "HP: 400/500");
                Check("11d. HP slider updates correctly", view.hpSlider.value == 400);
                Check("11k. TitanAvatar is visible when awakened", view.titanAvatar.activeSelf);
                Check("11l. ExplanationText is visible when awakened", view.explanationText.gameObject.activeSelf);
                Check("11m. TitanAvatarImage is visible when awakened", view.titanAvatarImage.gameObject.activeSelf);

                // 11f. Explanation text updates correctly
                Check("11f. Explanation text contains battle instructions", view.explanationText.text.Contains("Each attack sends all ready Guards"));

                // 11g. Status when no guards ready
                Check("11g. Status explains no ready Guards", view.statusText.text.Contains("No ready Guards"));

                // 11h. Status when guards ready
                snap.villagers.Add(new VillagerSnapshot { id = "g1", job = "Guard", hp = 100 });
                view.RenderState(snap);
                Check("11h. Status explains ready Guards count", view.statusText.text.Contains("1 Guards ready"));

                // 11e. Panel remains visible after defeat
                snap.titanState = new TitanState { isAwakened = true, isDefeated = true };
                view.RenderState(snap);
                Check("11e. Panel remains visible after defeat", go.activeSelf);
                Check("11i. Attack button disabled after defeat", !view.btnAttackTitan.interactable);
                Check("11j. Status text shows victory after defeat", view.statusText.text == "Fallen Titan defeated. Endgame victory achieved.");
                Check("11n. TitanAvatarImage remains visible after defeat", view.titanAvatarImage.gameObject.activeSelf);

                Object.DestroyImmediate(go);
            }

            // Group 12: Existing objective regression
            {
                var state = new GameSnapshot();
                Check("12a. objectiveState exists initially", state.objectiveState != null);
                Check("12b. objectiveText initialized", !string.IsNullOrEmpty(state.objectiveText));
                
                var backend = new LocalGameBackend();
                var stateField = typeof(LocalGameBackend).GetField("state", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                var checkObjectivesMethod = typeof(LocalGameBackend).GetMethod("CheckObjectives", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var testState = new GameSnapshot();
                testState.villagers.Add(new VillagerSnapshot { id = "v1", hp = 100, job = "Builder" });
                testState.day = 10;
                testState.objectiveState.currentMilestoneIndex = 5;
                stateField.SetValue(backend, testState);
                checkObjectivesMethod.Invoke(backend, null);

                var resultState = backend.GetSnapshot();
                Check("12c. Day 10 victory still triggers", resultState.gameStatus == "Victory" && resultState.isGameOver);
                Check("12d. QuestState intact", resultState.questState != null);
            }

            // Group 13: Accepted systems regression
            {
                var state = new GameSnapshot();
                Check("13a. WorldMapState initializes", state.worldMapState != null);
                Check("13b. TradeState initializes", state.tradeState != null);
                Check("13c. QuestState initializes", state.questState != null);
                Check("13d. Forbidden MainCanvas files do not exist", 
                    !File.Exists("Assets/_Project/Scripts/Editor/MainCanvasSetupTool.cs") &&
                    !File.Exists("Assets/_Project/Scripts/Editor/ForceRunSetup.cs") &&
                    !File.Exists("Assets/Prefabs/MainCanvas.prefab"));
            }

            // Group 14: WorldMap path test
            {
                var backend = new LocalGameBackend();
                var snap = backend.GetSnapshot();

                Check("14a. Locations exist", snap.worldMapState?.locations != null);
                
                // Confirm all path locations exist in definition list and have correct coordinates
                var expectedCoords = new Dictionary<string, (int x, int y)> {
                    { "home", (5, 5) },
                    { "northernVillage", (5, 6) },
                    { "lightHouseRuins", (6, 7) },
                    { "agatha", (7, 7) },
                    { "volandor", (8, 8) },
                    { "finalCastle", (9, 9) }
                };

                foreach (var kvp in expectedCoords) {
                    var loc = snap.worldMapState.locations.FirstOrDefault(l => l.id.Equals(kvp.Key, System.StringComparison.OrdinalIgnoreCase));
                    Check($"14b. Location {kvp.Key} exists", loc != null);
                    if (loc != null) {
                        Check($"14c. Location {kvp.Key} coordinates are correct: ({loc.x}, {loc.y}) matches expected ({kvp.Value.x}, {kvp.Value.y})", 
                            loc.x == kvp.Value.x && loc.y == kvp.Value.y);
                    }
                }
            }

            // Group 15: finalCastle unlock test via step-by-step route
            {
                var backend = new LocalGameBackend();
                var snap = backend.GetSnapshot();

                // Starting from home (5, 5), which is discovered at start.
                // We execute discoveries step by step.
                var steps = new[] { "northernVillage", "lightHouseRuins", "agatha", "volandor", "finalCastle" };
                
                for (int i = 0; i < steps.Length; i++) {
                    var stepId = steps[i];
                    var cmd = new DiscoverWorldMapLocationCommand { locationId = stepId };
                    var res = backend.Execute(cmd);
                    Check($"15a. Step {i+1}: Discover {stepId} succeeds", res.success);
                    
                    var updatedSnap = backend.GetSnapshot();
                    var stepLoc = updatedSnap.worldMapState.locations.First(l => l.id == stepId);
                    Check($"15b. Step {i+1}: {stepId} is marked discovered", stepLoc.isDiscovered);
                }

                var finalSnap = backend.GetSnapshot();
                Check("15c. finalCastle discovery awakens Titan", finalSnap.titanState.isAwakened);
                Check("15d. endgame objective text updates safely", finalSnap.objectiveText == "Endgame: Defeat the Fallen Titan at the Castle.");
            }

            // Group 16: UI test
            {
                var go = new GameObject("TestWorldMapPanel");
                var view = go.AddComponent<WorldMapPanelView>();

                var nameGo = new GameObject("TxtLocationName");
                nameGo.transform.SetParent(go.transform);
                view.txtLocationName = nameGo.AddComponent<Text>();

                var qadGo = new GameObject("TxtQADiscover");
                qadGo.transform.SetParent(go.transform);
                view.txtQADiscover = qadGo.AddComponent<Text>();

                var snap = new GameSnapshot();
                // Setup locations
                snap.worldMapState.locations.Add(new WorldMapLocationState { id = "home", displayName = "Home", x = 5, y = 5, isDiscovered = true });
                snap.worldMapState.locations.Add(new WorldMapLocationState { id = "volandor", displayName = "Volandor", x = 8, y = 8, isDiscovered = false });
                snap.worldMapState.locations.Add(new WorldMapLocationState { id = "finalCastle", displayName = "Fallen Titan Castle", x = 9, y = 9, isDiscovered = false });
                
                view.SelectLocation("finalCastle");
                view.UpdateView(snap);

                Check("16a. WorldMapPanel displays finalCastle details name clearly", 
                    view.txtLocationName.text.Contains("Fallen Titan Castle") && view.txtLocationName.text.Contains("Endgame Location"));

                Check("16b. QA discover status mentions Volandor when finalCastle is blocked", 
                    view.txtQADiscover.text.Contains("Blocked") && view.txtQADiscover.text.Contains("Volandor"));

                // Verify TitanBossPanel appears after finalCastle discovery
                var titanBossGo = new GameObject("TestTitanBossPanel");
                var titanBossView = titanBossGo.AddComponent<TitanBossPanelView>();
                
                var titleGo = new GameObject("TitleText");
                titleGo.transform.SetParent(titanBossGo.transform);
                titanBossView.titleText = titleGo.AddComponent<Text>();

                var statusGo = new GameObject("StatusText");
                statusGo.transform.SetParent(titanBossGo.transform);
                titanBossView.statusText = statusGo.AddComponent<Text>();

                var hpGo = new GameObject("HpText");
                hpGo.transform.SetParent(titanBossGo.transform);
                titanBossView.hpText = hpGo.AddComponent<Text>();

                var sliderGo = new GameObject("HpSlider");
                sliderGo.transform.SetParent(titanBossGo.transform);
                titanBossView.hpSlider = sliderGo.AddComponent<Slider>();

                var btnGo = new GameObject("BtnAttackTitan");
                btnGo.transform.SetParent(titanBossGo.transform);
                titanBossView.btnAttackTitan = btnGo.AddComponent<Button>();

                // When Titan is not awakened
                var snapNotAwakened = new GameSnapshot();
                snapNotAwakened.titanState = new TitanState { isAwakened = false };
                titanBossView.RenderState(snapNotAwakened);
                Check("16c. TitanBossPanel hidden before finalCastle discovery", !titanBossGo.activeSelf);

                // When Titan is awakened
                var snapAwakened = new GameSnapshot();
                snapAwakened.titanState = new TitanState { isAwakened = true, hp = 500, maxHp = 500 };
                titanBossView.RenderState(snapAwakened);
                Check("16d. TitanBossPanel visible after finalCastle discovery awakens Titan", titanBossGo.activeSelf);

                UnityEngine.Object.DestroyImmediate(go);
                UnityEngine.Object.DestroyImmediate(titanBossGo);
            }

            // Group 17: Visual Clarity and Battle Round Explanation checks
            {
                var backend = new LocalGameBackend();
                var snap = backend.GetSnapshot();

                // Setup awakened state
                var stateField = typeof(LocalGameBackend).GetField("state", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                var testState = new GameSnapshot();
                testState.titanState = new TitanState { isAwakened = true, hp = 500, maxHp = 500 };
                // 4 Guards
                testState.villagers.Add(new VillagerSnapshot { id = "g1", name = "G1", job = "Guard", hp = 100 });
                testState.villagers.Add(new VillagerSnapshot { id = "g2", name = "G2", job = "Guard", hp = 100 });
                testState.villagers.Add(new VillagerSnapshot { id = "g3", name = "G3", job = "Guard", hp = 100 });
                testState.villagers.Add(new VillagerSnapshot { id = "g4", name = "G4", job = "Guard", hp = 100 });
                stateField.SetValue(backend, testState);

                var cmd = new AttackTitanCommand { attackerVillagerIds = new List<string> { "g1", "g2", "g3", "g4" } };
                var res = backend.Execute(cmd);
                Check("17a. Attack succeeds in visual explanation check", res.success);

                var updatedSnap = backend.GetSnapshot();
                Check("17b. lastBattleResult contains guard count", updatedSnap.titanState.lastBattleResult.Contains("4 Guards") || updatedSnap.titanState.lastBattleResult.Contains("4 guards"));
                Check("17c. lastBattleResult contains damage dealt", updatedSnap.titanState.lastBattleResult.Contains("Dealt") || updatedSnap.titanState.lastBattleResult.Contains("dealt"));
                Check("17d. lastBattleResult contains return damage", updatedSnap.titanState.lastBattleResult.Contains("returned") || updatedSnap.titanState.lastBattleResult.Contains("return"));
                Check("17h. lastBattleResult contains Titan HP", updatedSnap.titanState.lastBattleResult.Contains("Titan HP"));

                // Defeat triggers victory
                testState.titanState.hp = 1;
                var resDefeat = backend.Execute(cmd);
                Check("17e. Defeating Titan triggers game victory status", resDefeat.success);
                var finalSnap = backend.GetSnapshot();
                Check("17f. Titan defeated flag is true", finalSnap.titanState.isDefeated);
                Check("17g. Game status is Victory", finalSnap.gameStatus == "Victory");
            }

            report.AppendLine();
            report.AppendLine($"Total PASS: {pass}");
            report.AppendLine($"Total FAIL: {fail}");

            string reportPath = "Assets/_Project/Docs/TitanEndgameTestReport.md";
            try
            {
                File.WriteAllText(reportPath, report.ToString());
                UnityEngine.Debug.Log($"TitanEndgameTest Report written to {reportPath}");
            }
            catch (System.Exception ex)
            {
                UnityEngine.Debug.LogError($"TitanEndgameTest could not write report: {ex.Message}");
            }

            }
            finally
            {
                if (globalBackedUp)
                {
                    try
                    {
                        if (File.Exists(realSavePath)) File.Delete(realSavePath);
                        File.Copy(globalBackupPath, realSavePath);
                        File.Delete(globalBackupPath);
                    }
                    catch {}
                }
                else
                {
                    try
                    {
                        if (File.Exists(realSavePath)) File.Delete(realSavePath);
                    }
                    catch {}
                }
            }

            UnityEngine.Debug.Log($"TitanEndgameTest Run Complete! PASS: {pass}, FAIL: {fail}.");

            if (fail > 0)
            {
                EditorApplication.Exit(1);
            }
        }
    }
}
