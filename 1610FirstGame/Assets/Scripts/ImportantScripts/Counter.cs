using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{
    public int value = 3, minValue = 0;
    public float waitTime = 1;

    public UnityEvent OnCountEvent, OnEndEvent;

    public void StartCounter()
    {
        StartCoroutine(RunCounter());
    }

    private IEnumerator RunCounter()
    {
        var waitObj = new WaitForSeconds(waitTime);
        
        while (value > minValue)
        {
            yield return waitObj;
            OnCountEvent.Invoke();
            value--;
        }

        yield return waitObj;
        OnEndEvent.Invoke();
    }
}
