using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;

public class DamageTrigger : MonoBehaviour
{
    public FloatSobjData playerHealthSobj;
    public FloatSobjData playerDamageSobj;
    public FloatSobjData enemyDamageSobj;
    public FloatSobjData enemyHealthSobj;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            playerHealthSobj.Value -= enemyDamageSobj.Value;
        }
        
        if (other.gameObject.name == "Punch")
        {
            enemyHealthSobj.Value -= playerDamageSobj.Value;
        }
    }
}
