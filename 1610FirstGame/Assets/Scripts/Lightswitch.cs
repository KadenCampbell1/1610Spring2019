using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Lightswitch : ScriptableObject
{
    public bool activateLight;
    // Start is called before the first frame update

    private void OnEnable()
    {
        
    }


    public void TurnOnOff()
    {
        if (activateLight)
        {
            activateLight = false;
        }
        else
        {
            activateLight = true;
        }
    }

}
