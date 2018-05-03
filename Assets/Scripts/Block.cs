using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {


    [System.Serializable]
    public class BlockSprites // All the sprites for the different colored blocks
    {
        public Sprite[] blocks;
        public string colorName;

        public int getLength() {
            return this.blocks.Length;
        }
        public string getcolorName() {
            return this.colorName;
        }
        public Sprite[] blocksArr() {
            return this.blocks;
        }

    }
    public BlockSprites[] difBlocks;
    public string shapeName;
    public GameObject blockPrefab; // interchangeable with shapePrefab in some of the scripts
    public int colorName;
    void Start()
    {
        int blockIDX = Random.Range(0, difBlocks.Length); // pick from array of different blocks
        colorName = blockIDX; // Used to match colors 0-17 for different colors;
        BlockSprites blockpicked = difBlocks[blockIDX]; // block that was picked
        makeRandomblock(blockpicked);
    }
    public void makeRandomblock(BlockSprites blocks) // pass in the color/block that was picked in the start method
    {
        int arrayIdx = Random.Range(0, blocks.getLength()); // Select Random shape to pick
        Sprite[] blocksArr = blocks.blocksArr(); // returns the array of sprites from the inner class
        Sprite blockShapePicked = blocksArr[arrayIdx];
        // Make the block the shape selected
        blockPrefab.GetComponent<SpriteRenderer>().sprite = blockShapePicked;
       // Set name for the shape selected, will be used with keeping track of score, alongside the color name
        switch (arrayIdx+1)
        {
            case 1:
                shapeName = "Cross";
                break;
            case 2:
                shapeName = "Circle";
                break;
            case 3:
                 shapeName = "Square";
                break;
            case 4:
                 shapeName = "Triangle";
                break;
            default:
                 shapeName = "Star";
                break;

        }
       // Debug.Log(shapeName);
    }
}

