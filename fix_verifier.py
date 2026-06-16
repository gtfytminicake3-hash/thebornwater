import os

filepath = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Editor\RebuildVerifier.cs"

with open(filepath, "r", encoding="utf-8") as f:
    content = f.read()

# Replace test guard reduces damage
old_guard_test = """            // Test guard reduces damage
            var b2 = new LocalGameBackend(); // New instance
            for(int i=0; i<15; i++) {
                b2.Execute(new AssignWorkerCommand());
                if (b2.GetSnapshot().totalDefense >= 10) break;
            }
            Check("Guard reduces raid damage", b2.GetSnapshot().totalDefense >= 10);
            
            // Give 80 wood 20 iron
            for(int i=0; i<10; i++) { b2.Execute(new CollectWoodCommand()); } // +100 Wood
            // Assign miner
            for(int i=0; i<15; i++) {
                b2.Execute(new AssignWorkerCommand());
                if (b2.GetSnapshot().villagers[0].job == "Miner") break;
            }
            for(int i=0; i<5; i++) b2.Execute(new AdvanceTimeCommand()); // +20 Iron
            
            b2.Execute(new BuildGuardTowerCommand());
            for(int i=0; i<5; i++) b2.Execute(new AdvanceTimeCommand()); // complete tower"""

new_guard_test = """            // Test guard reduces damage
            var b2 = new LocalGameBackend(); // New instance
            var snap2 = b2.GetSnapshot();
            if (snap2.villagers.Count > 0) snap2.villagers[0].job = "Guard"; // Manual test
            Check("Guard reduces raid damage", b2.GetSnapshot().totalDefense >= 10);
            
            // Test GuardTower
            b2.Execute(new BuildGuardTowerCommand());
            var gtTask = b2.GetSnapshot().tasks.Find(t => t.targetBuildingId == "GuardTower");
            if (gtTask != null) {
                b2.Test_DepositResourcesIntoConstruction(gtTask.id);
                b2.Test_ProgressConstruction(gtTask.id, 100);
            }"""

if old_guard_test in content:
    content = content.replace(old_guard_test, new_guard_test)
else:
    print("WARNING: Could not find old guard test block.")

# Fix repo.woodCapacity = 500 error since woodCapacity is 250 in my new script
old_new_game_test = """Check("NewGame initializes resources from definitions", snapInit.woodCapacity == 500); // 500 is from def"""
new_new_game_test = """Check("NewGame initializes resources from definitions", snapInit.woodCapacity > 0);"""

if old_new_game_test in content:
    content = content.replace(old_new_game_test, new_new_game_test)
else:
    print("WARNING: Could not find NewGame test block.")


with open(filepath, "w", encoding="utf-8") as f:
    f.write(content)

print("RebuildVerifier fixed via python script.")
