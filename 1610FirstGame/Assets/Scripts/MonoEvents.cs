﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{

    public UnityEvent startEvent, enableEvent, mouseDownEvent, updateEvent;
    
    
    void Start()
    {
        startEvent.Invoke();
    }

    private void OnEnable()
    {
        
    }

    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
