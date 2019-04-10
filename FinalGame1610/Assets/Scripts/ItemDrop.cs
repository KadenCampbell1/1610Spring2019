using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public ListOfThings myList;

    private void OnCollisionEnter(Collision other)
    {
        //gameObject. = myList.collectionList[Random.Range(0, myList.collectionList.Count)];
    }
}
