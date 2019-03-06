using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ComboChecker : MonoBehaviour
{
    public UnityEvent ComboEvent;
    
    public bool comboCheck;
    public float comboDamage;

    private void Update()
    {
        if (comboCheck)
        {
            ComboEvent.Invoke();
        }
    }
}
