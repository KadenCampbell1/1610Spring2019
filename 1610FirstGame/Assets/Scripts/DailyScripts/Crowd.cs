using UnityEngine;

namespace DailyScripts
{
    public class Crowd : MonoBehaviour
    {
        public int crowdCapacity;

        public Color personColor;

        public Vector3 personPosition;
        // Start is called before the first frame update
        void Start()
        {
            crowdCapacity = Random.Range(1, 100000);
            //choose random color
            //make seat range and assign random numbers between seat ranges
            //make loop to assign position and color
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
