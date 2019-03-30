using UnityEngine;
using UnityEngine.Events;

namespace ImportantScripts
{
    public class MoveCharacter : MonoBehaviour
    {
        public UnityEvent OnGrounded, OffGrounded;
        public MoveBase myCharacterMover;    
        public CharacterController myController;
    
        // Start is called before the first frame update
        void Start()
        {
            myController = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            if (myController.isGrounded)
            {
                OnGrounded.Invoke();
            }
            else
            {
                OffGrounded.Invoke();
            }
        
            myCharacterMover.Move(myController);

//

        
        
        
        }
    }
}
