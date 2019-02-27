using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class NewInventoryData : ScriptableObject
{
    public int newInventoryTotal;
    public int newItemTotal;

    private void OnEnable()
    {
        newInventoryTotal = 10;
        newItemTotal = 1;
    }

    public void CheckInventory()
    {
        if (newItemTotal >= newInventoryTotal)
        {
            //dont pick up item
        }
        else
        {
            //allow to pick up item
        }
    }
}
