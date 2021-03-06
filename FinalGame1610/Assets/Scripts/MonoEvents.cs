﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Integrated from School lessons
public class MonoEvents : MonoBehaviour
{
    public UnityEvent OnTriggerEnterEvent, OnCollisionEvent, OnMouseDownEvent, OnMouseUpEvent, OnTriggerStayEvent, OnTriggerExitEvent, OnStartEvent, OnUpdateEvent;
    public UnityEvent OnEnableEvent;
    
    public void OnTriggerEnter(Collider other)
    {
        OnTriggerEnterEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        OnTriggerExitEvent.Invoke();
    }

    private void OnCollisionEnter(Collision other)
    {
        OnCollisionEvent.Invoke();
    }

    private void OnMouseDown()
    {
        OnMouseDownEvent.Invoke();
    }

    private void OnMouseUp()
    {
        OnMouseUpEvent.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        OnTriggerStayEvent.Invoke();
    }

    private void Start()
    {
        OnStartEvent.Invoke();
    }

    private void OnEnable()
    {
        OnEnableEvent.Invoke();
    }

    private void Update()
    {
        OnUpdateEvent.Invoke();
    }

    public void DestorySelf()
    {
        Destroy(gameObject);
    }
}
