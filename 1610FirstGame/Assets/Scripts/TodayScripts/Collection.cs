using System.Collections.Generic;
using UnityEngine;

namespace TodayScripts
{
    [CreateAssetMenu]
    public class Collection : ScriptableObject
    {
        public List<Object> collectionList;
    
        public void Collect(Object obj)
        {
            collectionList.Add(obj);
        }
    }
}
