using UnityEngine;
using UnityEngine.SceneManagement;

namespace TheBonwater.Rebuild
{
    public class GameBootstrap : MonoBehaviour
    {
        void Start()
        {
            if (GameServiceLocator.Backend == null)
            {
                GameServiceLocator.RegisterBackend(new LocalGameBackend());
            }
            SceneManager.LoadScene(GameConstants.SCENE_MAIN_MENU);
        }
    }
}