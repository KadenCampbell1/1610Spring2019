using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Integrated from School Lessons
//Not being used
public class CharacterEventCheck : MonoBehaviour
{
    public Collider myCollider;
    public MyEvents myEvent;
    public float typeValue;
    
    public enum MyCollider
    {
        Item,
        Damage,
        Wall
    }

    public MyCollider CurrentCollider;


    private void OnTriggerEnter(Collider other)
    {
        switch (CurrentCollider)
        {
            case MyCollider.Item:
                myEvent.AddValue(typeValue);
                gameObject.SetActive(false);
                break;
            case MyCollider.Damage:
                myEvent.AddValue(typeValue);
                break;
            case MyCollider.Wall:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        
    }
}
