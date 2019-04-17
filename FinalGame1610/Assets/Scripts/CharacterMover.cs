using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;
using UnityEngine.Events;


//Integrated code from Mimo and school lessons
public class CharacterMover : MonoBehaviour
{
    public MoveBase myCharacterMover;
    public CharacterController myController;
    public SpriteRenderer mySpriteRenderer;
    public GameObject punchObj;
    public GameObject defObj;
    public bool canFlipPunch;
    //public Camera myCamera;
    //public bool flipCamera;
    

    void Start()
    {
        myController = GetComponent<CharacterController>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        canFlipPunch = true;
        //myCamera = GetComponent<Camera>();
    }

    void Update()
    {
        
        
//        if (flipCamera)
//        {
//            myCamera.transform.position.x = -myCamera.transform.position.x;
//        }

        if (Input.GetKeyDown("x"))
        {
            mySpriteRenderer.flipX = true;
            if (canFlipPunch)
            {
                punchObj.transform.Rotate(0,180,0);
                defObj.transform.Rotate(0,180,0);
                canFlipPunch = false;
            }
            //flipCamera = true;
            //gameObject.transform.Rotate(0,180,0);
        }

        if (Input.GetKeyDown("c"))
        {
            mySpriteRenderer.flipX = false;
            if (!canFlipPunch)
            {
                punchObj.transform.Rotate(0, 180, 0);
                defObj.transform.Rotate(0,180,0);
                canFlipPunch = true;
            }
            //flipCamera = false;
        }
        
        myCharacterMover.Move(myController);
    }
}
