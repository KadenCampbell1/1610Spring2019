using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveBase : ScriptableObject
{
    protected Vector3 myPosition;
    public float mySpeed = 30;
    public float jumpForce = 1.5f;
    public float myGravity = -3;
    
    public abstract void Move(CharacterController myController);
}
