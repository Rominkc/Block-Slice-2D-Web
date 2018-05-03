using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetScore : MonoBehaviour {

	// reset player high score
	public void resetHighScore()
    {
        PlayerPrefs.DeleteAll();
    }
}
