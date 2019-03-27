using UnityEngine;
using UnityEngine.Events;

namespace DailyScripts
{
    public class NewOnEvent : MonoBehaviour
    {
        public UnityEvent turnOn, turnOff;

        public bool boolOn;
    
    
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (boolOn)
            {
                print("On");
                turnOn.Invoke();
            }
            else
            {
                turnOff.Invoke();
                print("Off");
            }
        }
    }
}
