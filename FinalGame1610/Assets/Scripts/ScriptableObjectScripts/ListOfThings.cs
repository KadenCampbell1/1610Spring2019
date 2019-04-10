using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;

[CreateAssetMenu]
public class ListOfThings : ScriptableObject
{
    public List<GameObject> collectionList;
    
    public void Collect(GameObject obj)
    {
        collectionList.Add(obj);
    }
}
