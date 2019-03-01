using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OpenObject : MonoBehaviour
{
    public UnityEvent OpenEvent, CloseEvent;
    
    public bool openObjectBool;
    //public Vector3 myVector3;
    void Start()
    {
        
    }

    void Update()
    {
        if (openObjectBool)
        {
            OpenEvent.Invoke();
        }
        else
        {
            CloseEvent.Invoke();
        }
    }

    public void RotateObject(Vector3 myVector3)
    {
        gameObject.transform.Rotate(myVector3);
    }
}
