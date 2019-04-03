using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundChanger : MonoBehaviour
{
    public BackgroundValues myBackgroundValues;
    public Image myBackgroundImage;
    public GameObject myTriggerObject;
    
    
    //this trigger needs to be on triggerObject 
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player" && myBackgroundValues.backgroundMoving)
        {
            if (Input.GetAxis("Horizontal") > 0 && !myBackgroundValues.originalColor)
            {
                myBackgroundValues.backgroundColorInt += 10;
            }

            if (Input.GetAxis("Horizontal") < 0 && !myBackgroundValues.originalColor)
            {
                myBackgroundValues.backgroundColorInt -= 10;
            }
        }
    }

    private void FixedUpdate()
    {

        //have bool to check if it changes to a new name which makes it stop then on trigger exit to make it false
        //overlap the triggers to make sure the colors dont continue to change
        switch (myBackgroundValues.myName)
        {
            case BackgroundValues.MyBackgroundName.Foreground:
                myBackgroundValues.originalBlue = 255;
                myBackgroundValues.originalGreen = 255;
                myBackgroundValues.originalRed = 255;
                break;
            case BackgroundValues.MyBackgroundName.Midground:
                myBackgroundValues.originalRed = 142;
                myBackgroundValues.originalGreen = 154;
                myBackgroundValues.originalBlue = 200;
                break;
            case BackgroundValues.MyBackgroundName.Background:
                myBackgroundValues.originalRed = 95;
                myBackgroundValues.originalGreen = 105;
                myBackgroundValues.originalBlue = 144;
                break;
        }
        
        
        var backgroundBlue = myBackgroundImage.color.b;
        var backgroundGreen = myBackgroundImage.color.g;
        var backgroundRed = myBackgroundImage.color.r;
        backgroundBlue = myBackgroundValues.backgroundColorInt;
        backgroundGreen = myBackgroundValues.backgroundColorInt;
        backgroundRed = myBackgroundValues.backgroundColorInt;

        if (backgroundBlue == 144)
        {
            myBackgroundValues.originalColor = true;
            backgroundBlue = 144;
        }

        if (backgroundGreen == 105)
        {
            myBackgroundValues.originalColor = true;
            backgroundGreen = 105;
        }

        if (backgroundRed == 95)
        {
            myBackgroundValues.originalColor = true;
            backgroundRed = 95;
        }
    }
}
