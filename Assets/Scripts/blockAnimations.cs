using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockAnimations : MonoBehaviour {
    public GameObject squarePrefab; // To check the color of the block hit
    public GameObject shapeSlicedPrefab; // make object be able to reference itself, so that it is able to update the compenent for the sprite
    //public Animator anim; // animator that was supposed to be used but decided not to
    public Sprite[] brokenBlocks;
    int color;
    // Called when the object is first instantiated so that it doesn't update
    // Matches the color from the block sliced and creates an object that is "sliced" in the Block script
    void Start() {
 
        color = BoxHit.colorName;
        if (squarePrefab != null)
        {
            instBlockBreak(color);

        }
    }
    
    
    void instBlockBreak(int blockColor)
    {
        Sprite brokenBlock;
        brokenBlock = brokenBlocks[blockColor];
        shapeSlicedPrefab.GetComponent<SpriteRenderer>().sprite = brokenBlock;
        Debug.Log("This worked "+ blockColor);
    }




    //*** attempt but below function did not work out
   /* void playBlockBreak(int blockColor)// play the block animation corresponding to the right color
    {
        
        switch (blockColor)
        {
            case 0: anim.Play("Tan Break");
                break;
            case 1:
                anim.Play("Dark Tan Break");
                break;
            case 2:
                anim.Play("Dark Green Break");
                break;
            case 3:
                anim.Play("Green Break");
                break;
            case 4:
                anim.Play("Light Green Break");
                break;
            case 5:
                anim.Play("Blue Break");
                break;
            case 6:
                anim.Play("Dark Blue Break");
                break;
            case 7:
                anim.Play("Purple Break");
                break;
            case 8:
                anim.Play("Violet Break");
                break;
            case 9:
                anim.Play("Pink Purple Break");
                break;
            case 10:
                anim.Play("Pink Red Break");
                break;
            case 11:
                anim.Play("Red Break");
                break;
            case 12:
                anim.Play("Dark Red Break");
                break;
            case 13:
                anim.Play("Brown Break");
                break;
            case 14:
                anim.Play("Orange Break");
                break;
            case 15:
                anim.Play("Light Gray Break");
                break;
            case 16:
                anim.Play("Gray Break");
                break;
            default:
                anim.Play("Dark Gray Break");
                break;

        }
    } */

}
