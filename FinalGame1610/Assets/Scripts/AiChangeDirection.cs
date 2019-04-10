using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR.Interaction;

//Integrated from Mimo and school
public class AiChangeDirection : MonoBehaviour
{
    private bool keepGoing;  
    public bool moveLeft;
    public Rigidbody myRigidBody;
    public float enemySpeed;
    public bool verticalMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        moveLeft = false;
    }

    public void ChangeMoveLeft()
    {
        moveLeft = !moveLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if (!verticalMovement)
        {
            if (moveLeft)
            {
                transform.localScale = new Vector2(-1, 1);
                myRigidBody.velocity = new Vector2(-enemySpeed, myRigidBody.velocity.y);
            }
            else
            {
                transform.localScale = new Vector2(1, 1);
                myRigidBody.velocity = new Vector2(enemySpeed, myRigidBody.velocity.y);
            }
        }
        else
        {
            if (moveLeft)
            {
                transform.localScale = new Vector2(-1, 1);
                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, -enemySpeed);
            }
            else
            {
                transform.localScale = new Vector2(1, 1);
                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, enemySpeed);
            }
        }

        
    }
}
