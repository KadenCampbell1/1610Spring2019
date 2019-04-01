using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.PlayerLoop;

[CreateAssetMenu]
public class StateMachine : ScriptableObject
{

    public UnityEvent StartingEvent, PlayingEvent, EndingEvent;
    
    public enum States
    {
        Starting,
        Playing,
        Ending
    }
    
    public States currentState;

    public void ChangeToStarting()
    {
        currentState = States.Starting;
    }
    

    public void OnSwitch()
    {
        switch (currentState)
        {
            case States.Starting:
                StartingEvent.Invoke();
                break;
            case States.Playing:
                PlayingEvent.Invoke();
                break;
            case States.Ending:
                EndingEvent.Invoke();
                break;
            default:
                break;
        }
    }
}
