using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent OnTriggerEnterEvent;

    public void OnTriggerEnter(Collider other)
    {
        OnTriggerEnterEvent.Invoke();
    }
}
