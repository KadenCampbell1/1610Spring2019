﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnotherAnimCall : MonoBehaviour
{
    public UnityEvent AnotherAnimCallEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        AnotherAnimCallEvent.Invoke();
    }
}