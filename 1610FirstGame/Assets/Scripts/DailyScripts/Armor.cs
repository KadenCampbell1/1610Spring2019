using UnityEngine;

namespace DailyScripts
{
    public class Armor : MonoBehaviour
    {
        public int armor;

        public int armorUp;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void OnCollisionEnter2D(Collision2D other)
        {
            armor += armorUp;
        }
    }
}
