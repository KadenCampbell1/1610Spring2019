using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;

[CreateAssetMenu]
public class ListOfThings : ScriptableObject
{
    public List<FloatSobjData> collectionList;
    
    public void Collect(FloatSobjData obj)
    {
        collectionList.Add(obj);
    }
}
