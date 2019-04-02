using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class WeaponSwitch : ScriptableObject
{
    public UnityEvent pistolEvent, rifleEvent, crossbowEvent;
    
    public enum WeaponStates
    {
        Pistol,
        Rifle,
        Crossbow
    }

    public WeaponStates myWeapon;

    public void ChangeToPistol()
    {
        myWeapon = WeaponStates.Pistol;
    }
    
    public void ChangeToRifle()
    {
        myWeapon = WeaponStates.Rifle;
    }
    
    public void ChangeToCrossbow()
    {
        myWeapon = WeaponStates.Crossbow;
    }

    public void ChangeWeapon()
    {
        switch (myWeapon)
        {
            case WeaponStates.Pistol:
                pistolEvent.Invoke();
                break;
            case WeaponStates.Rifle:
                rifleEvent.Invoke();
                break;
            case WeaponStates.Crossbow:
                crossbowEvent.Invoke();
                break;
            default:
                break;
        }
    }

}
