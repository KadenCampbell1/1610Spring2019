using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class NewStringData : ScriptableObject
{
    public string newGlobalString;

    private void OnEnable()
    {
        newGlobalString = "Save the World";
    }
}
