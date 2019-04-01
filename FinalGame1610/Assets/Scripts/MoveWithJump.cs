using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Integrated code from school lessons
[CreateAssetMenu]
public class MoveWithJump : MoveBase
{
    public float originalSpeed;
    public override void Move(CharacterController myController)
    {
        
        if (myController.isGrounded && Input.GetButton("Vertical"))
        {
            myPosition.y = jumpForce;
        }

        if (Input.GetButton("Fire3"))
        {
            mySpeed = mySprintSpeed;
        }
        else
        {
            mySpeed = originalSpeed;
        }

        myPosition.y += myGravity * Time.deltaTime;
        myPosition.x = Input.GetAxis("Horizontal") * mySpeed * Time.deltaTime;
        myController.Move(myPosition);
    }
}
