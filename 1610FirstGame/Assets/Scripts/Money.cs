using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Money : ScriptableObject
{
    public int moneyTotal;
    public int moneyValue;

    public void AddAmount()
    {
        moneyTotal += moneyValue;
    }
}
