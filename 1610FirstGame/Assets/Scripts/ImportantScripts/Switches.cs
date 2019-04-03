using System;
using UnityEngine;
using UnityEngine.Events;

namespace ImportantScripts
{
    public class Switches : MonoBehaviour
    {

        public UnityEvent StartingEvent, PlayingEvent, DyingEvent, EndingEvent;

        public enum States
        {
            Starting,
            Playing,
            Dying,
            Ending
        }

        public States currentState;
    
        void Update()
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
                case States.Dying:
                    DyingEvent.Invoke();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
