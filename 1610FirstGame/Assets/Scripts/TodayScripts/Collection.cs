using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collection : ScriptableObject
{
    public List<Object> collectionList;
    
    public void Collect(Object obj)
    {
        collectionList.Add(obj);
    }
}
