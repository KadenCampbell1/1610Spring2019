using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent OnTriggerEnterEvent, OnCollisionEvent, OnMouseDownEvent, OnMouseUpEvent;

    public void OnTriggerEnter(Collider other)
    {
        OnTriggerEnterEvent.Invoke();
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

    
}
