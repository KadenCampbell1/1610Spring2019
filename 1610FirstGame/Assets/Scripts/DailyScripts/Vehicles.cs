using UnityEngine;

namespace DailyScripts
{
    [CreateAssetMenu]
    public class Vehicles : ScriptableObject
    {
        public string carName;
        public float carSpeed;
        public float carHandling;
    
        //add a function to check for a button and switch it to the car sprite to move
    }
}
