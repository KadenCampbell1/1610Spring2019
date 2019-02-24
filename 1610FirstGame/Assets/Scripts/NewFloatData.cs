using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class NewFloatData : ScriptableObject
{
    public float newGlobalFloat;

    private void OnEnable()
    {
        newGlobalFloat = 4.6f;
    }
}
