using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Highscore : MonoBehaviour {

    public GameObject newHigh; // set active if new high score
    int highScore = ScoreCount.currentScore;
    TextMeshProUGUI highScoreText;
    // Set the score to the score the user got from playing the game, before they lost
    void Start()
    {
        
        highScoreText = GetComponent<TextMeshProUGUI>();
        if (PlayerPrefs.GetInt("Highscore") < 1) // set highscore to a default value if it doesn't exist
        {
            PlayerPrefs.SetInt("Highscore", 0);
            highScoreText.text = "";
        }
       
        if (highScore > PlayerPrefs.GetInt("Highscore")) // if new highscore set the new object to true and display that highscore
        {
            PlayerPrefs.SetInt("Highscore", highScore);
            newHigh.SetActive(true);
            highScoreText.text = PlayerPrefs.GetInt("Highscore").ToString();
        }
        else     // else player did not get new high score and display previous high score
        {
            newHigh.SetActive(false);
            highScoreText.text = PlayerPrefs.GetInt("Highscore").ToString();

        }


    }
   
}
