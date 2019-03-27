using System.Collections.Generic;
using UnityEngine;

namespace ImportantScripts
{
    [CreateAssetMenu]
    public class Collection : ScriptableObject
    {
        public List<FloatData> collectionList;
    
        public void Collect(FloatData obj)
        {
            collectionList.Add(obj);
        }

        public void CollectionInfo()
        {
            foreach (var obj in collectionList)
            {
                Debug.Log(obj);
            }
        }

        public void AmmoInfo()
        {
            foreach (var obj in collectionList)
            {
                if (obj.name == "Ammo")
                {
                    Debug.Log("we have " + obj.Value + " Ammo.");
                }
            }
        }

        public void FuelInfo()
        {
            for (int i = 0; i < collectionList.Count; i++)
            {
                if (collectionList[i].name == "Fuel")
                {
                    Debug.Log(collectionList[i]);
                }
            }
        }
    }
}
