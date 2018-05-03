
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {
    public Text scoreText;
    public static int currentScore;
    public GameObject ColorPick;
    public GameObject squarePrefab;
    void Start()
    {
        currentScore = 0;
    }
	// Update is called once per frame
	void Update () {
        
        scoreText.text = currentScore.ToString();
	}
  

}
