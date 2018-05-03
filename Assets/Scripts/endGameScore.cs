using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class endGameScore : MonoBehaviour {

    int GameScore = ScoreCount.currentScore;
    TextMeshProUGUI scoreText;
    // Set the score to the score the user got from playing the game, before they lost
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = GameScore.ToString();

    }
   

}
