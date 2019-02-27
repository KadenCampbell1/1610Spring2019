using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{
    public UnityEvent OnGrounded, OffGrounded;
    
    public float mySpeed = 3;
    
    private CharacterController myController;
    private Vector3 myPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        myController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myController.isGrounded)
        {
            OnGrounded.Invoke();
        }
        else
        {
            OffGrounded.Invoke();
        }
        
        myPosition.y = Input.GetAxis("Vertical") * mySpeed * Time.deltaTime;
        myPosition.x = Input.GetAxis("Horizontal") * mySpeed * Time.deltaTime;
        
        myController.Move(myPosition);
    }
}
