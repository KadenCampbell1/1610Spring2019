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
    //public Camera myCamera;
    //public bool flipCamera;
    

    void Start()
    {
        myController = GetComponent<CharacterController>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
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
            punchObj.transform.localPosition = new Vector3(-1.41f, 0.68f, 0);
            //flipCamera = true;
            //gameObject.transform.Rotate(0,180,0);
        }

        if (Input.GetKey("c"))
        {
            mySpriteRenderer.flipX = false;
            punchObj.transform.localPosition = new Vector3(1.41f, 0.68f, 0);
            //flipCamera = false;
        }
        
        myCharacterMover.Move(myController);
    }
}
