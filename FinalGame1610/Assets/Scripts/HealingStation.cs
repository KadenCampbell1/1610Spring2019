using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;
using UnityEngine.Events;

//Integrated from School Lessons
public class HealingStation : MonoBehaviour
{
    public float waitTime = 1;
    public FloatSobjData healthData;

    
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
