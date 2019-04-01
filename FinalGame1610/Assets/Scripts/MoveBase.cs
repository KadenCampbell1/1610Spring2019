using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Integrated code from school lessons
[CreateAssetMenu]
public abstract class MoveBase : ScriptableObject
{
    protected Vector3 myPosition;
    public float mySpeed;
    public float mySprintSpeed;
    public float jumpForce;
    public float myGravity;

    public abstract void Move(CharacterController myController);
}
