using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//Integrated from Unity's script reference page
public class ItemDrop : MonoBehaviour
{
    public ListOfThings myList;
    public int itemLife;
    public int rngReturn;
    private float counter;


    private void OnTriggerEnter(Collider other)
    {
        itemLife --;
        if (itemLife <= 0)
        {
            ObjInstance();
            gameObject.SetActive(false);
        }
    }

    
    
    //make a switch with preset items that the rngNumber gives a number and then it is that switches preset that the foreach can generate for each obj in said switch
    
    
    
    public void ObjInstance()
    {
        foreach (var myObj in myList.collectionList)
        {
            counter++;
            Instantiate(myObj, new Vector3(counter * 2.0f, 0, 0), Quaternion.identity);
        }
    }

    public int rngNumberMaker(int numTotal)
    {
        for (int i = 0; i < numTotal + 1; i++)
        {
             rngReturn = Random.Range(0, myList.collectionList.Count);
        }

        return rngReturn;
    }
}
