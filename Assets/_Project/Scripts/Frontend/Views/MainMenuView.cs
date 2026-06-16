using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild
{
    public class MainMenuView : MonoBehaviour
    {
        public Button btnNewGame;
        public Button btnLoadGame;

        void Start()
        {
            btnNewGame.onClick.AddListener(() => MainMenuPresenter.OnNewGame());
            btnLoadGame.onClick.AddListener(() => MainMenuPresenter.OnLoadGame());
        }
    }
}