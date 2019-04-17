﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefEvent : MonoBehaviour
{
    public GameObject DefObj;
    public bool ObjOn;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
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