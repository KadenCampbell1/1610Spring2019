using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoveWithAxis : MoveBase
{
    public override void Move(CharacterController myController)
    {
        if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
        {
            myPosition.y = Input.GetAxis("Vertical") * mySpeed * Time.deltaTime;
        }
        else
        {
            myPosition.y = myGravity * Time.deltaTime;
        }

            myPosition.x = Input.GetAxis("Horizontal") * mySpeed * Time.deltaTime;
            myController.Move(myPosition);
    }
}
