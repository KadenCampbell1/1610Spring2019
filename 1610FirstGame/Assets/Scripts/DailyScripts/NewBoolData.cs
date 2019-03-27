using UnityEngine;

namespace DailyScripts
{
    [CreateAssetMenu]
    public class NewBoolData : ScriptableObject
    {
        public bool newGlobalBoolData;

        private void OnEnable()
        {
            newGlobalBoolData = true;
        }
    }
}
