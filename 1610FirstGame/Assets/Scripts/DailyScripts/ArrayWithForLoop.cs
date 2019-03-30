using System.Collections;
using System.Collections.Generic;
using ImportantScripts;
using UnityEngine;
using UnityEngine.Events;

public class ArrayWithForLoop : MonoBehaviour
{
    public FloatData[] itemsInPouch;
    public Collection collectionScriptForArray;
    public UnityEvent ArrayTriggerEvent;
    public int itemTotal;

    private void OnTriggerEnter(Collider other)
    {
        ArrayTriggerEvent.Invoke();
    }

    public void ArrayForLoop()
    {
        for (int i = 0; i < itemsInPouch.Length; i++)
        {
            collectionScriptForArray.collectionList.Add(itemsInPouch[i]);
        }
        
        print("Pouch had " + ListTotal() + " Items in it.");
    }

    public void ArrayForEach()
    {
        foreach (var obj in itemsInPouch)
        {
            collectionScriptForArray.collectionList.Add(obj);
        }
        
        print("Pouch had " + ListTotal() + " Items in it.");
    }

    private int ListTotal()
    {
        foreach (var obj in itemsInPouch)
        {
            itemTotal++;
        }

        return itemTotal;
    }
    
}
