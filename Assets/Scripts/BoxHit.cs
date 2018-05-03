using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHit : MonoBehaviour
{
    public GameObject shapeSlicedPrefab;
    public GameObject squarePrefab; // To check if the color matches with the color that is supposed to be sliced
    public GameObject ColorPick; // To check the color picked
    public static int colorName;// Based off the index of the color spawn by the squarePrefab
    public string shapeName;
    int compareColors;
    void Update()
    {
        compareColors = ColorPicker.rightColor;
      //  Debug.Log(compareColors);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            // Get the color name to see if you have a match
            // 0- Tan, 1- Dark Tan, 2- Dark Green, 3-Green, 4- Light Green, 5- Blue, 6- Dark Blue, 7- Purple, 8- Violet
            // 9-Pink Purple, 10-Pink Red, 11-Red, 12-Dark Red, 13- Brown, 14-Orange, 15- Light Gray, 16- Gray, 17-Dark Gray 
            int color = squarePrefab.GetComponent<Block>().colorName;
            colorName = color; // static variable that will be used to pick the right animation
            string shape = squarePrefab.GetComponent<Block>().shapeName;

            // Create the animation object and add scores here ect
            GameObject slicedBlock =Instantiate(shapeSlicedPrefab,transform.position,transform.rotation);
            Destroy(slicedBlock, 1f);
            // increment score based off of shape, and see if colors match, then destroy the block that was hit
            incremScore(color, shape);
            Debug.Log("We Hit a Box " + color +" ");
            Destroy(gameObject);
        }
    }
    void incremScore(int colorNames, string shapeNames) // increment score based on the shape hit, and compare the colors to see if you lose a life
    {
        int points = 0;
     // color that you should not hit or you will lose a life
        switch (shapeNames) // switch corresponding to how many points you should receive;
        {
            case "Cross":
                points = 10;
                break;
            case "Circle":
                points = 20;
                break;
            case "Square":
                points = 30;
                break;
            case "Triangle":
                points = 40;
                break;
            default:
                points = 50;
                break;
        }
                if (compareColors==colorNames) // compare if the colors are the same
        {
           GameControl.Lives -= 1;
         //  Debug.Log("You have " + GameControl.Lives + " " + colorName);
        }
        else ScoreCount.currentScore+= points;
      //  Debug.Log(ScoreCount.currentScore);

    }

   
}