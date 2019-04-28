using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

//Integrated from School Lessons
public class MyEvents : MonoBehaviour
{
    public FloatSobjData typeSobj;
    
    public void AddValue(float value)
    {
        typeSobj.Value += value;
    }
}
