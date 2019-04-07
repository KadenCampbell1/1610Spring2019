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
    public Camera myCamera;
    public bool flipCamera;
    

    void Start()
    {
        myController = GetComponent<CharacterController>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        myCamera = GetComponent<Camera>();
    }

    void Update()
    {
        
        
        if (flipCamera)
        {
            //myCamera.transform.position.x = -myCamera.transform.position.x;
        }

        if (Input.GetKey("x"))
        {
            mySpriteRenderer.flipX = true;
            flipCamera = true;
        }

        if (Input.GetKey("c"))
        {
            mySpriteRenderer.flipX = false;
            flipCamera = false;
        }
        
        myCharacterMover.Move(myController);
    }
}
