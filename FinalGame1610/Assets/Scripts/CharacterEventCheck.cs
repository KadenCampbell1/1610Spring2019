using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEventCheck : MonoBehaviour
{
    public Collider myCollider;
    public MyEvents myEvent;
    public float typeValue;
    
    public enum MyCollider
    {
        Item,
        Damage,
    }

    public MyCollider CurrentCollider;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == myCollider.gameObject)
        {
            switch (CurrentCollider)
            {
                case MyCollider.Item:
                    myEvent.AddValue(typeValue);
                    gameObject.SetActive(false);
                    break;
                case MyCollider.Damage:
                    other.gameObject.GetComponent<UpdateBar>().fillNumber = myEvent.typeSobj;
                    myEvent.AddValue(typeValue);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
