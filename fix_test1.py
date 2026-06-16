import sys

file_path = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Editor\AutoGameplayUITest.cs"

with open(file_path, "r", encoding="utf-8") as f:
    content = f.read()

replacement = """            // 10. Add resources and build Storage
            // TEST_ONLY: Add resources via reflection because backend does not expose API
            var stateField = typeof(LocalGameBackend).GetField("state", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            if (stateField != null) {
                var s = stateField.GetValue(backend) as GameSnapshot;
                if (s != null) {
                    s.wood = 1000;
                    s.food = 1000;
                    s.iron = 1000;
                }
            }"""

content = content.replace("            // 10. Add resources and build Storage\n            backend.Execute(new DevCheatCommand { wood = 1000, food = 1000, iron = 1000 });", replacement)

with open(file_path, "w", encoding="utf-8") as f:
    f.write(content)

print("Updated AutoGameplayUITest.cs")
