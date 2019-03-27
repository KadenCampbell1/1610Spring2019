using UnityEngine;
using UnityEngine.Events;

namespace DailyScripts
{
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
}
