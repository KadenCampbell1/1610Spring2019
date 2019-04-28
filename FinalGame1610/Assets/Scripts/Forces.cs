using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Integrated from School Lessons
public class Forces : MonoBehaviour
{
    public Vector3 forceAmount;
    private Rigidbody rBody;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }


    public void ApplyForce()
    {
        rBody.AddForce(forceAmount);
    }
}
