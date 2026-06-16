import os
import re

file_path = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Backend\Runtime\LocalGameBackend.cs"
with open(file_path, "r", encoding="utf-8") as f:
    code = f.read()

# Fix BuildGuardTowerCommand execution
code = code.replace("if (isGameOver) return;", "if (state.isGameOver) return result;")
code = code.replace("if (wood >= 80 && iron >= 20)", "if (state.wood >= 80 && state.iron >= 20)")
code = code.replace("wood -= 80;", "state.wood -= 80;")
code = code.replace("iron -= 20;", "state.iron -= 20;")
code = code.replace('targetId = "GuardTower"', "")
code = code.replace(', status = "IN_PROGRESS"', "")
code = code.replace("LogTask", "Log")

# Fix AdvanceTimeCommand block logic
code = code.replace("if (isGameOver) {", "if (state.isGameOver) {")
code = code.replace('LogTask("Game is over. Cannot advance time.");', 'Log("Game is over. Cannot advance time.");')
code = code.replace("return;", "return result;")
code = code.replace("int prevTime = timeOfDay;", "int prevTime = state.timeOfDay;")
code = code.replace("timeOfDay++;", "state.timeOfDay++;")
code = code.replace("if (timeOfDay > 3) {", "if (state.timeOfDay > 3) {")
code = code.replace("timeOfDay = 0;", "state.timeOfDay = 0;")
code = code.replace("day++;", "state.day++;")
code = code.replace("if (timeOfDay != prevTime) {", "if (state.timeOfDay != prevTime) {")
code = code.replace("var gt = buildings.Find", "var gt = state.buildings.Find")
code = code.replace("foreach (var v in villagers) {", "foreach (var v in state.villagers) {")
code = code.replace("wood +=", "state.wood +=")
code = code.replace("food +=", "state.food +=")
code = code.replace("iron +=", "state.iron +=")
code = code.replace("for (int i = tasks.Count", "for (int i = state.tasks.Count")
code = code.replace("var t = tasks[i];", "var t = state.tasks[i];")
code = code.replace("t.status = \"COMPLETED\";", "")
code = code.replace("var b = buildings.Find(x => x.id == t.targetId);", "var b = state.buildings.Find(x => x.id == (t.type == \"BuildHut\" ? \"Hut\" : \"GuardTower\"));")
code = code.replace("if (b != null) b.count++;\n                        else buildings.Add(new BuildingSnapshot { id = t.targetId, count = 1 });", 
                    'if (b != null) b.count++;\n                        else state.buildings.Add(new BuildingSnapshot { id = (t.type == "BuildHut" ? "Hut" : "GuardTower"), count = 1 });')
code = code.replace("LogTask($\"{t.targetId}", "Log($\"{t.type}")
code = code.replace("tasks.RemoveAt(i);", "state.tasks.RemoveAt(i);")

code = code.replace("if (timeOfDay == 0) {", "if (state.timeOfDay == 0) {")
code = code.replace("if (food >= 5)", "if (state.food >= 5)")
code = code.replace("food -= 5;", "state.food -= 5;")

code = code.replace("if (timeOfDay == 3", "if (state.timeOfDay == 3")
code = code.replace("!isObjectiveComplete", "!state.isObjectiveComplete")
code = code.replace("lastRaidDay != day", "state.lastRaidDay != state.day")
code = code.replace("lastRaidDay = day;", "state.lastRaidDay = state.day;")
code = code.replace("enemies.Add(", "state.enemies.Add(")
code = code.replace("if (wood >=", "if (state.wood >=")
code = code.replace("wood -= 10;", "state.wood -= 10;")
code = code.replace("enemies.Remove(", "state.enemies.Remove(")
code = code.replace("isGameOver = true;", "state.isGameOver = true;")

code = code.replace("foreach (var v in villagers) if (v.hp > 0 && v.job == \"Guard\") defense += 10;", 
                    "foreach (var v in state.villagers) if (v.hp > 0 && v.job == \"Guard\") defense += 10;")
code = code.replace("var gt = buildings.Find(b => b.id == \"GuardTower\");", 
                    "var gt = state.buildings.Find(b => b.id == \"GuardTower\");")


with open(file_path, "w", encoding="utf-8") as f:
    f.write(code)
print("Syntax fixed")
