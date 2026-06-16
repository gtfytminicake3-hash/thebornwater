using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TheBonwater.Rebuild.Diagnostics;

namespace TheBonwater.Rebuild {
    public class MainMenuController : MonoBehaviour {
        public Button btnNewGame;
        public Button btnContinue;

        private void Start() {
            if (btnNewGame != null) btnNewGame.onClick.AddListener(OnNewGame);
            if (btnContinue != null) btnContinue.onClick.AddListener(OnContinue);
            
            string savePath = Path.Combine(Application.persistentDataPath, "local_runtime_save.json");
            if (btnContinue != null) {
                btnContinue.interactable = File.Exists(savePath);
            }
        }

        private void OnNewGame() {
            RuntimeTrace.Log("UI_CLICK", "Button=NewGame Scene=MainMenu");
            string savePath = Path.Combine(Application.persistentDataPath, "local_runtime_save.json");
            if (File.Exists(savePath)) File.Delete(savePath); // Delete old save for fresh start
            
            GameServiceLocator.RegisterBackend(new LocalGameBackend()); // Init fresh backend
            RuntimeTrace.Log("SCENE_FLOW", "Transition=MainMenu->TownScene");
            SceneManager.LoadScene("TownScene");
        }

        private void OnContinue() {
            RuntimeTrace.Log("UI_CLICK", "Button=Continue Scene=MainMenu");
            GameServiceLocator.RegisterBackend(new LocalGameBackend()); // Will auto-load inside LocalGameBackend constructor
            RuntimeTrace.Log("SCENE_FLOW", "Transition=MainMenu->TownScene");
            SceneManager.LoadScene("TownScene");
        }
    }
}
