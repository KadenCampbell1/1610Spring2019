using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEventCheck : MonoBehaviour
{
    public Collider myCollider;
    
    public enum MyCollider
    {
        Item,
        Damage
    }

    public MyCollider CurrentCollider;

    //trigger event could be problem
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == myCollider.gameObject)
        {
            switch (CurrentCollider)
            {
                case MyCollider.Item:
                    print("test");
                    break;
                case MyCollider.Damage:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
