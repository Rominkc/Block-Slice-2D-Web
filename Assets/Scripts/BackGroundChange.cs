using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This script is used to change the background color based on user score
public class BackGroundChange : MonoBehaviour {
    public Camera mainCam;
	// Use this for initialization
	void Start () {
       mainCam.backgroundColor = new Color (.667f, .667f, .667f, 0); // gray color
        
        Debug.Log(mainCam.backgroundColor);
	}
	
	// Update is called once per frame
    // Set the background to different colors based on user score
	void Update () {
        Debug.Log(mainCam.backgroundColor);
        if (ScoreCount.currentScore > 2000 && ScoreCount.currentScore < 4000) {
            mainCam.backgroundColor = new Color(.632f, .529f, .511f, 0);
        }
        else if (ScoreCount.currentScore > 4000 && ScoreCount.currentScore < 6000)
        {
            mainCam.backgroundColor = new Color(.576f, .632f, .511f, 0);
        }
        else if (ScoreCount.currentScore > 6000 && ScoreCount.currentScore < 8000)
        {
            mainCam.backgroundColor = new Color(.511f, .632f, .537f, 0);
        }
        else if (ScoreCount.currentScore > 8000 && ScoreCount.currentScore < 10000)
        {
            mainCam.backgroundColor = new Color(.511f, .632f, .627f, 0);
        }
        else if (ScoreCount.currentScore > 10000 && ScoreCount.currentScore < 12000)
        {
            mainCam.backgroundColor = new Color(.511f, .527f, .632f, 0);
        }
        else if (ScoreCount.currentScore > 12000 && ScoreCount.currentScore < 14000)
        {
            mainCam.backgroundColor = new Color(.616f, .511f, .632f, 0);
        }
        else if (ScoreCount.currentScore > 14000 && ScoreCount.currentScore < 16000)
        {
            mainCam.backgroundColor = new Color(.632f, .511f, .511f, 0);
        }
        else if (ScoreCount.currentScore > 16000 && ScoreCount.currentScore < 18000)
        {
            mainCam.backgroundColor = new Color(.904f, .266f, .266f, 0);
        }
        else if (ScoreCount.currentScore > 18000 && ScoreCount.currentScore < 20000)
        {
            mainCam.backgroundColor = new Color(.250f, .472f, 1.0f, 0);
        }
        else if (ScoreCount.currentScore > 20000)
        {
            mainCam.backgroundColor = new Color(0f, 0f, 0f, 0);
        }
        
    }       
}
