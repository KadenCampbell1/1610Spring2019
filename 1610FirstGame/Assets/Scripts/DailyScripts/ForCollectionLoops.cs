using System;
using System.Collections;
using System.Collections.Generic;
using ImportantScripts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using Object = System.Object;

namespace DailyScripts
{
    public class ForCollectionLoops : MonoBehaviour
    {
        public Collection collectionScript;

        public UnityEvent triggeredEvent;
//        public FloatData collectingObj;
//        public Collection collectionScript;
//        public FloatData floatDataItem;
//        public List<Object> collectionLoopList;

        private void Start()
        {
            
        }

        private void OnTriggerEnter(Collider other)
        {
            triggeredEvent.Invoke();
        }

        public void ForLoopCall(FloatData other)
        {
            for (var i = 0; i < collectionScript.collectionList.Count; i++)
            {
                collectionScript.collectionList.Add(other);
            }
        }

        public void ForEachLoopCall(FloatData other)
        {
            foreach (var obj in collectionScript.collectionList)
            {
                collectionScript.collectionList.Add(other);
            }
        }

//        private void ForCollection()
//        {
//            foreach (FloatData obj in OnTriggerEnter())
//            {
//                collectionScript.Collect(obj);
//            }
//        }
    }
}
