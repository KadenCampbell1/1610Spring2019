using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class NewBoolData : ScriptableObject
{
    public bool newGlobalBoolData;

    private void OnEnable()
    {
        newGlobalBoolData = true;
    }
}
