using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class PauseMenu : MonoBehaviour {
    
    public GameObject audiocam; // to pause music when the game is paused
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    AudioSource currentSong;
    void Start()
    {
        currentSong = audiocam.GetComponent<AudioSource>();
    }


	// Update is called once per frame
	void Update () {
// Pause game if you press escape, or resume if already paused
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
                
            }
            else
            {
                Pause();
                currentSong.Pause();
            }
        }

    }


    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        currentSong.Play();
    }
    
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        currentSong.Pause();
    }

    public void loadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start Menu");
        gameIsPaused = false;
    }
    
}
