using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TheBonwater.Rebuild.Data;
namespace TheBonwater.Rebuild {
    public class MockBackend : IGameBackend {
        private GameSnapshot state;
        private string savePath;
        public DataRepository repo { get; } = null;
        public MockBackend() {
            savePath = Path.Combine(Application.persistentDataPath, "local_runtime_save.json");
            InitNewState();
        }
        private void InitNewState() {
            state = new GameSnapshot();
            state.villagers.Add(new VillagerSnapshot { name = "Bryn", job = "Idle", hp = 100 });
            state.villagers.Add(new VillagerSnapshot { name = "Alaric", job = "Idle", hp = 100 });
            state.buildings.Add(new BuildingSnapshot { id = "Bonfire", count = 1 });
            state.buildings.Add(new BuildingSnapshot { id = "Hut", count = 0 });
            Log("Game Started.");
        }
        public CommandResult Execute(GameCommand command) {
            CommandResult result = new CommandResult { success = true };
            if (command is StartNewGameCommand) { InitNewState(); Log("Started New Game."); }
            else if (command is CollectWoodCommand) {
                int amount = 10;
                if (state.wood + amount <= state.woodCapacity) { state.wood += amount; Log($"+{amount} Wood collected. Wood: {state.wood}/{state.woodCapacity}"); }
                else { state.wood = state.woodCapacity; Log($"Wood capacity full. Wood: {state.wood}/{state.woodCapacity}"); }
            }
            else if (command is BuildHutCommand) {
                int cost = 50;
                if (state.wood >= cost) {
                    state.wood -= cost;
                    var hut = state.buildings.Find(b => b.id == "Hut");
                    if (hut == null) { hut = new BuildingSnapshot { id = "Hut", count = 0 }; state.buildings.Add(hut); }
                    hut.count++;
                    Log($"Built Hut. Wood: {state.wood}/{state.woodCapacity}. Buildings: {hut.count}");
                } else { result.success = false; result.message = "Not enough Wood. Need 50 Wood."; Log(result.message); }
            }
            else if (command is AssignWorkerCommand) {
                var idle = state.villagers.Find(v => v.job == "Idle");
                if (idle != null) { idle.job = "Woodcutter"; Log($"Assigned {idle.name} as Woodcutter."); }
                else { result.success = false; result.message = "No idle villagers available."; Log(result.message); }
            }
            else if (command is AdvanceTimeCommand) {
                if (state.timeOfDay == "Morning") state.timeOfDay = "Afternoon";
                else if (state.timeOfDay == "Afternoon") state.timeOfDay = "Evening";
                else if (state.timeOfDay == "Evening") state.timeOfDay = "Night";
                else if (state.timeOfDay == "Night") { state.timeOfDay = "Morning"; state.day++; }
                int woodcutters = state.villagers.FindAll(v => v.job == "Woodcutter").Count;
                if (woodcutters > 0) {
                    state.wood = Mathf.Min(state.wood + woodcutters * 5, state.woodCapacity);
                    Log($"Time advanced: Day {state.day} - {state.timeOfDay} (Woodcutters produced +{woodcutters * 5} Wood)");
                } else {
                    Log($"Time advanced: Day {state.day} - {state.timeOfDay}");
                }
            }
            else if (command is SaveGameCommand) {
                try { File.WriteAllText(savePath, JsonUtility.ToJson(state, true)); Log($"Game saved to local_runtime_save.json"); }
                catch (Exception e) { result.success = false; Log($"Failed to save: {e.Message}"); }
            }
            else if (command is LoadGameCommand) {
                if (File.Exists(savePath)) {
                    try { string json = File.ReadAllText(savePath); state = JsonUtility.FromJson<GameSnapshot>(json); Log("Game loaded from save."); }
                    catch (Exception e) { result.success = false; Log($"Failed to load: {e.Message}"); }
                } else { result.success = false; Log("No save file found."); }
            }
            else if (command is DismissExpeditionReportCommand) {
                if (state.pendingExpeditionReports != null && state.pendingExpeditionReports.Count > 0) {
                    state.pendingExpeditionReports.RemoveAt(0);
                    Log("Expedition report dismissed.");
                }
            }
            else if (command is TradeCommand) {
                Log("Mock Trade Command executed.");
            }
            return result;
        }
        private void Log(string msg) {
            state.lastAction = msg;
            state.taskLogs.Insert(0, msg);
            if (state.taskLogs.Count > 5) state.taskLogs.RemoveAt(state.taskLogs.Count - 1);
        }
        public GameSnapshot GetSnapshot() { return state; }
    }
}
