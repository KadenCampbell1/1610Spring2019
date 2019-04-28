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
    public Animator myAnimator;
    public float inputValue;
    

    void Start()
    {
        myController = GetComponent<CharacterController>();
    }

    void Update()
    {   
        myCharacterMover.Move(myController);
        inputValue = Input.GetAxis("Horizontal");
        myAnimator.SetFloat("HorizontalValue", inputValue); 
    }
}
