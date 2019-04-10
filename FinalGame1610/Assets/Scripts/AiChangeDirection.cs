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
    public bool doesRotate;
    public bool rotateSprite;
    
    // Start is called before the first frame update
    void Start()
    {
        moveLeft = false;
    }

    public void ChangeMoveLeft()
    {
        moveLeft = !moveLeft;
        rotateSprite = !rotateSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (!verticalMovement)
        {
            if (moveLeft)
            {
                if (doesRotate)
                {
                    GetComponent<SpriteRenderer>().flipX = rotateSprite;
                }
                
                myRigidBody.velocity = new Vector2(-enemySpeed, myRigidBody.velocity.y);
            }
            else
            {
                if (doesRotate)
                {
                    GetComponent<SpriteRenderer>().flipX = rotateSprite;
                }
                
                myRigidBody.velocity = new Vector2(enemySpeed, myRigidBody.velocity.y);
            }
        }
        else
        {
            if (moveLeft)
            {
                
                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, -enemySpeed);
            }
            else
            {
                
                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, enemySpeed);
            }
        }

        
    }
}
