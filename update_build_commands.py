import os
import re

filepath = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Backend\Runtime\LocalGameBackend.cs"
with open(filepath, "r", encoding="utf-8") as f:
    content = f.read()

def replace_build_command(content, cmd_type, target_building_id):
    # We will search for the block starting with: else if (command is BuildHutCommand) {
    # or if (command is BuildHutCommand) {
    pattern = r"// ORIGINAL_FIDELITY: PROTOTYPE_FALLBACK\s*// Evidence missing: original requires multi-step construction with labor\.\s*(else )?if \(command is " + cmd_type + r"\) \{.*?\}(?=\s*// ORIGINAL_FIDELITY|\s*else if)"
    
    new_cmd = f"""// ORIGINAL_FIDELITY: PROTOTYPE_FALLBACK
            // Exact construction labor values unknown. Construction state mapping follows evidence.
            {"else " if cmd_type != "BuildHutCommand" else ""}if (command is {cmd_type}) {{
                var def = repo.GetBuilding("{target_building_id}");
                if (def != null) {{
                    var task = new TaskSnapshot {{
                        id = Guid.NewGuid().ToString(),
                        type = "Build_{target_building_id}",
                        targetBuildingId = "{target_building_id}",
                        currentCompletion = 0,
                        finalCompletion = def.constructionRequired > 0 ? def.constructionRequired : 100, // Fallback
                        isResourcesComplete = false,
                        requiredResources = new List<ResourceAmount>(),
                        depositedResources = new List<ResourceAmount>()
                    }};
                    foreach (var kvp in def.costs) {{
                        task.requiredResources.Add(new ResourceAmount {{ resourceId = kvp.Key, amount = kvp.Value }});
                    }}
                    if (task.requiredResources.Count == 0) task.isResourcesComplete = true;
                    state.tasks.Add(task);
                    Log($"Construction site for {target_building_id} placed.");
                }} else {{
                    result.success = false; result.message = $"Building definition {target_building_id} not found."; Log(result.message);
                }}
            }}"""
            
    content = re.sub(pattern, new_cmd, content, flags=re.DOTALL)
    return content

content = replace_build_command(content, "BuildHutCommand", "Hut")
content = replace_build_command(content, "BuildStorageCommand", "Storage")
content = replace_build_command(content, "BuildGuardTowerCommand", "GuardTower")

with open(filepath, "w", encoding="utf-8") as f:
    f.write(content)

print("LocalGameBackend updated.")
