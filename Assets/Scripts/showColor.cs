using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showColor : MonoBehaviour {
    public Sprite[] blockSpritesDef;
    public GameObject blockExample;// Object that gets its sprite changed
    public GameObject ColorPickedObj;// Sprite object to matched from ColorPicked object
    int compareColors; // Used to pick the right sprite to display based on the current color picked (from the static var rightColor)
    void Update()
    {
        compareColors = ColorPicker.rightColor;
        spriteColor(compareColors);

    }
    void spriteColor(int compareColors) // Modify this code to pick the right shape to display based on the color picked from ColorPicker script
      {
       

          switch (compareColors + 1)
          {
              case 1:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 2:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 3:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 4:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 5:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 6:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 7:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 8:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 9:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 10:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 11:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 12:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 13:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 14:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 15:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 16:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
              case 17:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
                default:
                  blockExample.GetComponent<Image>().sprite = blockSpritesDef[compareColors];
                  break;
          }
      } 
}
