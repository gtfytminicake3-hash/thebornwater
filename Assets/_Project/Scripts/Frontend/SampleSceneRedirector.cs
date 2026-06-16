using UnityEngine;
using UnityEngine.SceneManagement;

namespace TheBonwater.Rebuild
{
    public class SampleSceneRedirector : MonoBehaviour
    {
        void Start()
        {
            if (Application.CanStreamedLevelBeLoaded(GameConstants.SCENE_BOOT) || Application.CanStreamedLevelBeLoaded(0))
            {
                UnityEngine.Debug.Log("[Rebuild] Redirecting from SampleScene to BootScene...");
                SceneManager.LoadScene(GameConstants.SCENE_BOOT);
            }
            else
            {
                UnityEngine.Debug.LogError("[Rebuild] BootScene is not in Build Settings! Cannot redirect.");
            }
        }
    }
}
