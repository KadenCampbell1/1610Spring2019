using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Experimental.XR;
using UnityEngine.UI;
//Integrated from school
public class BackgroundChanger : MonoBehaviour
{
    public Sprite[] backgroundSprites;
    public SpriteRenderer myRenderer;
    public GameObject myPlayer;


    private void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>();
    }

    public enum currentBackground
    {
        Hills,
        Cave
    }

    public currentBackground myBackground;
    
    private void Update()
    {
        switch (myBackground)
        {
            case currentBackground.Hills:
                myRenderer.sprite = backgroundSprites[0];
                transform.position = new Vector3(myPlayer.transform.position.x, myPlayer.transform.position.y - 3.9f, myPlayer.transform.position.z + 25);
                transform.localScale = new Vector3(1, 1, 1);
                break;
            case currentBackground.Cave:
                myRenderer.sprite = backgroundSprites[1];
                transform.position = new Vector3(myPlayer.transform.position.x - 0.0309f, myPlayer.transform.position.y + 0.04824f, myPlayer.transform.position.z + 25);
                transform.localScale = new Vector3(1.27551f, 1.27551f, 1.27551f);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void ChangeBgToCave()
    {
        myBackground = currentBackground.Cave;
    }
    
    public void ChangeBgToHill()
    {
        myBackground = currentBackground.Hills;
    }
}
