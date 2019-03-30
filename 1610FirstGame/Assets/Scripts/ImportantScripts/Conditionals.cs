using UnityEngine;
using UnityEngine.Events;

namespace ImportantScripts
{
    public class Conditionals : MonoBehaviour
    {
        public UnityEvent OnEvent, OffEvent;
    
        public bool onBool;
        public int number = 11;
        public string password;
    
        // Update is called once per frame
        void Update()
        {
            if (onBool)
            {
                OnEvent.Invoke();
            }
            else
            {
                OffEvent.Invoke();
            }

            if (number >= 10)
            {
                print("greater");
            }
            else
            {
                print("less");
            }

            if (password == "Images")
            {
                print("and Words");
            }
            else
            {
                print("Over Time");
            }
        
        }
    }
}
