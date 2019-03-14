using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFunctions : MonoBehaviour
{
    
    public int a;
    public int b;
    public int c;

    public Vector3 position;
    public CharacterController controller;
    
    private int Add()
    {
        return a + b;
    }

    private int Subtract()
    {
        return a - b;
    }

    private int Multiply()
    {
        return a * b;
    }

    public Vector3 Move()
    {
        position.y = Input.GetAxis("Horizontal");
        controller.Move(position);

        return position;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        c = Add();
        c = Subtract();
        c = Multiply();
    }
    
    
}
