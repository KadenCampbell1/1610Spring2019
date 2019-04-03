using UnityEngine;
using UnityEngine.Events;

namespace ImportantScripts
{
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
}
