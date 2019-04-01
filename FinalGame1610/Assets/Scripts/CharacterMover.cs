using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


//Integrated code from Mimo and school lessons
public class CharacterMover : MonoBehaviour
{
    public MoveBase myCharacterMover;
    public CharacterController myController;
    public SpriteRenderer mySpriteRenderer;

    void Start()
    {
        myController = GetComponent<CharacterController>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        if (Input.GetKey("x"))
        {
            mySpriteRenderer.flipX = true;
        }

        if (Input.GetKey("c"))
        {
            mySpriteRenderer.flipX = false;
        }
        
        myCharacterMover.Move(myController);
    }
}
