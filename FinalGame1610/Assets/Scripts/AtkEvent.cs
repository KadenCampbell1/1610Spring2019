using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;
using UnityEngine.Serialization;

//Integrated from School and Unity's Web page
public class AtkEvent : MonoBehaviour
{
    public GameObject atkObj;
    public GameObject torsoObj;
    public GameObject headObj;
    public FloatSobjData manaSobj;
    public GameObject flameFist;
    public bool objOn;
    public bool primaryAttackOn;
    
    public enum WeaponState
    {
        Primary,
        Secondary
    }

    public WeaponState currentWeapon;

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && !Input.GetMouseButton(1))
        {
            objOn = true;
            if (currentWeapon == WeaponState.Secondary)
            {
                manaSobj.Value -= 0.1f;
            }
            
            switch (currentWeapon)
            {
                case WeaponState.Primary:
                    break;
                case WeaponState.Secondary:
                    flameFist.SetActive(objOn);
                    Instantiate(flameFist, new Vector3(atkObj.transform.position.x + 0.44f, atkObj.transform.position.y + 0.3f, atkObj.transform.position.z), atkObj.transform.rotation);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            objOn = false;
        }

        
        flameFist.SetActive(false);
        atkObj.SetActive(objOn);
        torsoObj.SetActive(!objOn);
        headObj.SetActive(!objOn);

        if (manaSobj.Value > 0)
        {
            if (Input.GetKeyDown("f"))
            {
                primaryAttackOn = !primaryAttackOn;
            }
        }
        else
        {
            primaryAttackOn = true;
        }        

        if (primaryAttackOn)
        {
            currentWeapon = WeaponState.Primary;
        }
        else
        {
            currentWeapon = WeaponState.Secondary;
        }
    }
}
