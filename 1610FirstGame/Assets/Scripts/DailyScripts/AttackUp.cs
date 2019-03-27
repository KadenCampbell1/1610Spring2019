using UnityEngine;

namespace DailyScripts
{
    public class AttackUp : MonoBehaviour
    {
        public int attack;

        public int attackUp;
    
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
            attack += attackUp;
        }
    
    }
}
