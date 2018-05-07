using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class ColorPicker : MonoBehaviour {
    public AudioSource dingSound; // sound to play everytime a new color is picked
    public GameObject color; // the square prefab so you can get the color hit from it
    public static int rightColor;// Going to be used to calculate if player gets score added or loses a life
    public Text colorText;
    float minDelay = 1f;
    float maxDelay = 3f;
    // Update is called once per frame
    void Start()
    {
        colorText.text = "";
        colorText.text = chosenColor(pickAColorIDX());
        StartCoroutine(chooseColor()); // pick a random color
    }
    void Update () {
        
   
     
	}


    IEnumerator chooseColor() { 
     
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay); // delay between picking colors
            yield return new WaitForSeconds(delay);
          
            colorText.text = chosenColor(pickAColorIDX()); // set the text to the color, and pick color
            dingSound.Play();

        }

    }








    // Pick a Color to display and compare
    int pickAColorIDX() {
        int pickedColorIDX = Random.Range(0, 18);// 18 possible collors
        return pickedColorIDX;

    }
    // See which color the player hit
  //  int colorHit() {

      //  int colorHit = color.GetComponent<BoxHit>().colorName;
       // Debug.Log(colorHit);
     //   return colorHit; }
  
  
    
    string chosenColor(int colorIDX) // pick color based on the random number picked
    {
        rightColor = colorIDX; // set color that will be compared in BoxHit script
        switch (rightColor+1)
        {
            case 1:
                return "Tan:";
            case 2:
                return "Dark Tan:";
            case 3:
                return "Dark Green:";
            case 4:
                return "Green:";
            case 5:
                return "Light Green:";
            case 6:
                return "Blue:";
            case 7:
                return "Dark Blue:";
            case 8:
                return "Purple:";
            case 9:
                return "Violet:";
            case 10:
                return "Pink Purple:";
            case 11:
                return "Pink Red:";
            case 12:
                return "Red:";
            case 13:
                return "Dark Red:";
            case 14:
                return "Brown:";
            case 15:
                return "Orange:";
            case 16:
                return "Light Gray:";
            case 17:
                return "Gray:";
            default:
               return "Dark Gray:";
        }
    }
   

}
