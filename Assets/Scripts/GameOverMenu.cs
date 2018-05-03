using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {

    public void loadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start Menu");
        PauseMenu.gameIsPaused = false;
    }
    public void restartGame()
    {
        SceneManager.LoadScene("Main");
    }
}
