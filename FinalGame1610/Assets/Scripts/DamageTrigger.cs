using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;

//Integrated from School Lessons
public class DamageTrigger : MonoBehaviour
{
    public FloatSobjData playerHealthSobj;
    public FloatSobjData playerDamageSobj;
    public FloatSobjData enemyDamageSobj;
    public FloatSobjData enemyHealthSobj;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 12)
        {
            playerHealthSobj.Value -= enemyDamageSobj.Value;
        }
        
        if (other.gameObject.layer == 13)
        {
            enemyHealthSobj.Value -= playerDamageSobj.Value;
        }
    }
}
