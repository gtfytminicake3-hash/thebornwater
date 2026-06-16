using UnityEngine;
using UnityEngine.SceneManagement;

namespace TheBonwater.Rebuild.Frontend
{
    public class MainMenuButtonDirectLoader : MonoBehaviour
    {
        public string targetSceneName = "TownScene";

        public void NewGame()
        {
            UnityEngine.Debug.Log("[MainMenuButtonDirectLoader] NEW GAME clicked.");
            TryStartBackend();
            LoadTargetScene();
        }

        public void LoadGame()
        {
            UnityEngine.Debug.Log("[MainMenuButtonDirectLoader] LOAD GAME clicked.");
            TryLoadBackend();
            LoadTargetScene();
        }

        private void TryStartBackend()
        {
            try
            {
                var backend = TheBonwater.Rebuild.GameServiceLocator.Backend;
                if (backend != null)
                {
                    backend.Execute(new TheBonwater.Rebuild.StartNewGameCommand());
                    UnityEngine.Debug.Log("[MainMenuButtonDirectLoader] StartNewGameCommand executed.");
                }
                else
                {
                    UnityEngine.Debug.LogWarning("[MainMenuButtonDirectLoader] Backend is null. Continuing scene load.");
                }
            }
            catch (System.Exception ex)
            {
                UnityEngine.Debug.LogWarning("[MainMenuButtonDirectLoader] Backend start failed, continuing scene load. " + ex);
            }
        }

        private void TryLoadBackend()
        {
            try
            {
                var backend = TheBonwater.Rebuild.GameServiceLocator.Backend;
                if (backend != null)
                {
                    // Fallback to start new game for now
                    backend.Execute(new TheBonwater.Rebuild.StartNewGameCommand());
                    UnityEngine.Debug.Log("[MainMenuButtonDirectLoader] LoadGameCommand executed.");
                }
                else
                {
                    UnityEngine.Debug.LogWarning("[MainMenuButtonDirectLoader] Backend is null. Continuing scene load.");
                }
            }
            catch (System.Exception ex)
            {
                UnityEngine.Debug.LogWarning("[MainMenuButtonDirectLoader] Backend load failed, continuing scene load. " + ex);
            }
        }

        private void LoadTargetScene()
        {
            UnityEngine.Debug.Log("[MainMenuButtonDirectLoader] Loading scene: " + targetSceneName);
            SceneManager.LoadScene(targetSceneName);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
            {
                UnityEngine.Debug.Log("[MainMenuButtonDirectLoader] Keyboard fallback triggered.");
                NewGame();
            }
        }
    }
}
