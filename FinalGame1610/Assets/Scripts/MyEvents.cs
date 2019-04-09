using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MyEvents : MonoBehaviour
{
    //public UnityEvent myEvent;
    public FloatSobjData typeSobj;
    //public FloatSobjData thisObjSobj;
    
    public void AddValue(float value)
    {
        typeSobj.Value += value;
    }
}
