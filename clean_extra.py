import os

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts"

def write_file(path, content):
    full_path = os.path.join(base_dir, path)
    os.makedirs(os.path.dirname(full_path), exist_ok=True)
    with open(full_path, "w", encoding="utf-8") as f:
        f.write(content.strip() + "\n")

write_file(r"Backend\Runtime\LocalGameBackend.cs", "// empty")
write_file(r"Frontend\SceneFlowController.cs", """
using UnityEngine;
namespace TheBonwater.Rebuild {
    public class SceneFlowController : MonoBehaviour { }
}
""")
write_file(r"Frontend\Views\LoadingView.cs", """
using UnityEngine;
namespace TheBonwater.Rebuild {
    public class LoadingView : MonoBehaviour { }
}
""")
write_file(r"Frontend\Views\BuildMenuView.cs", """
using UnityEngine;
using UnityEngine.UI;
namespace TheBonwater.Rebuild {
    public class BuildMenuView : MonoBehaviour { 
        public Button btnBuildHut;
    }
}
""")
