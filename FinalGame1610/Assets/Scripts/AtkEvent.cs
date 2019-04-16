using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkEvent : MonoBehaviour
{
    public GameObject AtkObj;
    public bool ObjOn;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !Input.GetMouseButtonDown(2))
        {
            ObjOn = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            ObjOn = false;
        }
        
        AtkObj.SetActive(ObjOn);
    }
}
