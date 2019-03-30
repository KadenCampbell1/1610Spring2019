using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ImportantScripts;
using UnityEngine;

[CreateAssetMenu]
public class HealthInheriting : PowerUpBase
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        gloabalPowerUpValue = 100;
    }

    public void DamageDone(float minusValue)
    {
        gloabalPowerUpValue -= minusValue;
        
        if (gloabalPowerUpValue <= 0)
        {
            //System.Console.Write(string: "You are dead.");
            gloabalPowerUpValue = 100;
        }
    }
}
