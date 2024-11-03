using UnityEngine;
using UnityEngine.SceneManagement;

    public class MainMenuManager : MonoBehaviour
    {
        public void PlayGame()
        {
            // Загрузить сцену загрузки
            SceneManager.LoadScene("Main");
        }

        public void ExitGame()
        {
            Application.Quit();
        }

        public void LobbyRoom()
        {
            SceneManager.LoadScene("Loading");
        }
    }
