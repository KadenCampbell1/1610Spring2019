using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CubeLightScript : MonoBehaviour
{
    public bool lightOnOff;

    public Light theLight;
    // Start is called before the first frame update
    void Start()
    {
        //theLight = gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnMouseDown()
    {
        lightOnOff = !lightOnOff;
        if (lightOnOff)
        {
            theLight.enabled = true;
            print("Light On");
        }
        else
        {
            theLight.enabled = false;
            print("Light Off");
        }
    }
}
