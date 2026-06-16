import os

base = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts"

# 1. MainMenuPresenter.cs
p_presenter = os.path.join(base, r"Frontend\Presenters\MainMenuPresenter.cs")
with open(p_presenter, "w", encoding="utf-8") as f:
    f.write("""using UnityEngine;
using UnityEngine.SceneManagement;

namespace TheBonwater.Rebuild
{
    public static class MainMenuPresenter
    {
        public static void OnNewGame()
        {
            Debug.Log("[MainMenu] New Game clicked");
            var result = GameServiceLocator.Backend.Execute(new StartNewGameCommand());
            if (result.success) Debug.Log("[MainMenu] StartNewGameCommand success");
            else Debug.LogError("[MainMenu] StartNewGameCommand failed: " + result.errorCode);
            
            SceneFlowController.LoadTownScene();
        }

        public static void OnLoadGame()
        {
            Debug.Log("[MainMenu] Load Game clicked");
            var result = GameServiceLocator.Backend.Execute(new StartNewGameCommand()); // fallback to new game for MVP
            if (result.success) Debug.Log("[MainMenu] LoadGameCommand success (Mock)");
            
            SceneFlowController.LoadTownScene();
        }
    }
}
""")

# 2. SceneFlowController.cs
p_flow = os.path.join(base, r"Frontend\SceneFlowController.cs")
with open(p_flow, "w", encoding="utf-8") as f:
    f.write("""using UnityEngine;
using UnityEngine.SceneManagement;

namespace TheBonwater.Rebuild
{
    public class SceneFlowController : MonoBehaviour
    {
        public static void LoadTownScene()
        {
            Debug.Log("[SceneFlow] Loading TownScene");
            SceneManager.LoadScene("TownScene");
        }
    }
}
""")

# 3. MainMenuView.cs
p_view = os.path.join(base, r"Frontend\Views\MainMenuView.cs")
with open(p_view, "w", encoding="utf-8") as f:
    f.write("""using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild
{
    public class MainMenuView : MonoBehaviour
    {
        public Button btnNewGame;
        public Button btnLoadGame;

        void Start()
        {
            if (btnNewGame != null) btnNewGame.onClick.AddListener(MainMenuPresenter.OnNewGame);
            if (btnLoadGame != null) btnLoadGame.onClick.AddListener(MainMenuPresenter.OnLoadGame);
        }
    }
}
""")

# 4. TownView.cs
p_town = os.path.join(base, r"Frontend\Views\TownView.cs")
with open(p_town, "w", encoding="utf-8") as f:
    f.write("""using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild
{
    public class TownView : MonoBehaviour
    {
        public Button btnAdvanceTime;
        public Button btnSave;

        void Start()
        {
            Debug.Log("[TownScene] Town UI initialized");
            if (btnAdvanceTime != null) btnAdvanceTime.onClick.AddListener(TownPresenter.AdvanceTime);
            if (btnSave != null) btnSave.onClick.AddListener(TownPresenter.SaveGame);
        }
    }
}
""")

print("Wrote frontend flow classes.")
