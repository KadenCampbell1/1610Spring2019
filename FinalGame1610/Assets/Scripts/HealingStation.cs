using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;
using UnityEngine.Events;

public class HealingStation : MonoBehaviour
{
//    public int value = 3, minValue = 0;
    public float waitTime = 1;
    public FloatSobjData healthData;

//    private void HealEvent()
//    {
//        while (healthData.Value < 1)
//        {
//            healthData.Value += 0.1f;
//        }
//    }
    
//    private void OnTriggerStay(Collider other)
//    {
//        
//        while (healthData.Value < 1)
//        {
//            healthData.Value += 0.1f;
//        }
//    }
//
//    private void OnTriggerEnter(Collider other)
//    {
//        StartCounter();
//    }


    public void StartCounter()
    {
        StartCoroutine(RunCounter());
    }

    private IEnumerator RunCounter()
    {
        var waitObj = new WaitForSeconds(waitTime);
        
        while (healthData.Value < 1)
        {
            yield return waitObj;
            healthData.Value += 0.1f;
        }

        yield return waitObj;
    }
}
