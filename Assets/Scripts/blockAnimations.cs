using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class blockAnimations : MonoBehaviour {
   
    public GameObject shapeSlicedPrefab; // make object be able to reference itself, so that it is able to update the compenent for the sprite
    AudioSource sliceOrLoseLife; // sound made when sliced or lose life
    public AudioClip sliceClip, loseLifeClip;
   
    public Sprite[] brokenBlocks;
   public int color;
    // Called when the object is first instantiated so that it doesn't update
    // Matches the color from the block sliced and creates an object that is "sliced" in the Block script
    void Start() {
        sliceOrLoseLife = GetComponent<AudioSource>();
      
        playCorrectsound(); // set the audioSource to the right audioclip
    
         
            instBlockBreak(color);
            sliceOrLoseLife.Play(); //play the right sound
           
     
    }
    
    
    void instBlockBreak(int blockColor)
    {
        Sprite brokenBlock;
        brokenBlock = brokenBlocks[blockColor];
        shapeSlicedPrefab.GetComponent<SpriteRenderer>().sprite = brokenBlock;
        //Debug.Log("This worked "+ blockColor);
    }



    void playCorrectsound() // plays a slice sound or a lose life sound
    {
        if (color == ColorPicker.rightColor)
        {
            sliceOrLoseLife.clip = loseLifeClip;
        }
        else
        {
            sliceOrLoseLife.clip = sliceClip;
        }
    }
    
}
