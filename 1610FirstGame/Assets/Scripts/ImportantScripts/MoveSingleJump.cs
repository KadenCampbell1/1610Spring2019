using UnityEngine;

namespace ImportantScripts
{
    [CreateAssetMenu]
    public class MoveSingleJump : MoveBase
    {    
        public override void Move(CharacterController myController)
        {
            if (myController.isGrounded && Input.GetButton("Jump"))
            {
                myPosition.y = jumpForce;
            }
        
            myPosition.y += myGravity * Time.deltaTime;
            myPosition.x = Input.GetAxis("Horizontal") * mySpeed * Time.deltaTime;
            myController.Move(myPosition);

        }
    }
}
