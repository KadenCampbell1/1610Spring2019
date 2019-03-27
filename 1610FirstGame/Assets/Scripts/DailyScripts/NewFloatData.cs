using UnityEngine;

namespace DailyScripts
{
    [CreateAssetMenu]
    public class NewFloatData : ScriptableObject
    {
        public float newGlobalFloat;

        private void OnEnable()
        {
            newGlobalFloat = 4.6f;
        }
    }
}
