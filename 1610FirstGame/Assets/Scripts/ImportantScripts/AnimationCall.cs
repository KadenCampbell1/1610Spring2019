using UnityEngine;
using UnityEngine.Events;

namespace ImportantScripts
{
    public class AnimationCall : MonoBehaviour
    {
        public UnityEvent AnimCallEvent;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void OnMouseDown()
        {
            AnimCallEvent.Invoke();
        }
    }
}
