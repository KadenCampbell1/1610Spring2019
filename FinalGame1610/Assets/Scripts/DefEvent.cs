using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Integrated from School Lessons
public class DefEvent : MonoBehaviour
{
    public GameObject DefObj;
    public bool ObjOn;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && !Input.GetMouseButton(0))
        {
            ObjOn = true;
        }

        if (Input.GetMouseButtonUp(1))
        {
            ObjOn = false;
        }
        
        DefObj.SetActive(ObjOn);
    }
}
