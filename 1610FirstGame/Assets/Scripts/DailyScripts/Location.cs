using UnityEngine;

namespace DailyScripts
{
    public class Location : MonoBehaviour
    {
        public Vector3 myLocation;

        public GameObject player;

        private void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            myLocation = player.transform.position;
        }
    }
}
