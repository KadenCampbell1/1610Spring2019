using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NewLightSwitch : MonoBehaviour
{
    public UnityEvent onEvent, offEvent;
    
    public bool isOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {
            onEvent.Invoke();
        }
        else
        {
            offEvent.Invoke();
        }
    }
}
