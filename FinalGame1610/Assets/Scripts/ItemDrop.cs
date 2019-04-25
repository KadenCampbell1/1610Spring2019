using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;

//Integrated from Unity's script reference page
public class ItemDrop : MonoBehaviour
{
    public ListOfThings myList;
    public int itemLife;
    private int rngReturn;
    private float counter;
    private List<GameObject> rngList;
    private List<int> numberHolder;


    private void OnTriggerEnter(Collider other)
    {
        itemLife --;
        if (itemLife <= 0)
        {
            ObjInstance();
            gameObject.SetActive(false);
        }
    }
    
    
    public void ObjInstance()
    {
        //CreateRngList();
        rngNumberMaker(3);
        foreach (var myObj in rngList)
        {
            counter++;
            Instantiate(myObj, new Vector3(counter * 2.0f, 0, 0), Quaternion.identity);
        }
    }

//    private void CreateRngList()
//    {
//        //rngNumberMaker(3);
//        //numberHolder.Add(rngNumberMaker(3));
//        //print(rngReturn);
//        //rngList.Add(myList.collectionList[number]);
//        //print(rngList);
//    }

    private void rngNumberMaker(int numTotal)
    {
        for (int i = 0; i < numTotal + 1; i++)
        {
             rngReturn = Random.Range(0, myList.collectionList.Count);
             rngList.Add(myList.collectionList[rngReturn].gameObject);
        }
    }
}
