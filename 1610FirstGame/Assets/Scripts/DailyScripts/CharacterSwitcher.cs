using UnityEngine;

namespace DailyScripts
{
    public class CharacterSwitcher : MonoBehaviour
    {
        public bool isFirstCharacter;
    
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnMouseDown()
        {
            isFirstCharacter = !isFirstCharacter;
            if (isFirstCharacter)
            {
                //camera and controls equals first character
            }
            else
            {
                //camera and controls equals second character
            }
        }
    }
}
