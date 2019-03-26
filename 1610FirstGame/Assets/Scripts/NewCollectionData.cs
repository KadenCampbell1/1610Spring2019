using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class NewCollectionData : ScriptableObject
{
    public List<Object> newCollectionList;

    public void CollectObject(Object myObj)
    {
        newCollectionList.Add(myObj);
    }
}
