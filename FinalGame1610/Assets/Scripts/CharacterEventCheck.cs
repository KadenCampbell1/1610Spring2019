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
        Wall
    }

    public MyCollider CurrentCollider;


    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject == myCollider.gameObject)

        switch (CurrentCollider)
        {
            case MyCollider.Item:
                myEvent.AddValue(typeValue);
                gameObject.SetActive(false);
                break;
            case MyCollider.Damage:
//                    if (other.name == "Snail")
//                    {
//                        other.gameObject.GetComponent<UpdateBar>().fillNumber = myEvent.typeSobj;  
//                    }
                //myEvent.typeSobj = other.GetComponent<MyEvents>().thisObjSobj;
                myEvent.AddValue(typeValue);
                //myEvent.typeSobj = null;
                break;
            case MyCollider.Wall:
                //myEvent.typeSobj = null;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        
    }
}
