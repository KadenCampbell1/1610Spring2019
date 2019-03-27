using UnityEngine;

namespace DailyScripts
{
    [CreateAssetMenu]
    public class NewStringData : ScriptableObject
    {
        public string newGlobalString;

        private void OnEnable()
        {
            newGlobalString = "Save the World";
        }
    }
}
