using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUpBase : ScriptableObject
{
    public float gloabalPowerUpValue = 10.5f;

    public void OnPowerUp(float addValue)
    {
        gloabalPowerUpValue += addValue;
    }

    public void OnPowerDown(float minusValue)
    {
        gloabalPowerUpValue -= minusValue;
    }
}
