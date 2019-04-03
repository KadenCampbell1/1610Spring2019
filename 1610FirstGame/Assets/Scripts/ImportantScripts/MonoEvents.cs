using UnityEngine;
using UnityEngine.Events;

namespace ImportantScripts
{
    public class MonoEvents : MonoBehaviour
    {

        public UnityEvent startEvent, enableEvent, mouseDownEvent, updateEvent, TriggerEnterEvent, CollisionEnterEvent;
    
    
        void Start()
        {
            startEvent.Invoke();
        }

        private void OnEnable()
        {
            enableEvent.Invoke();
        }

        private void OnMouseDown()
        {
            mouseDownEvent.Invoke();
        }

        private void OnTriggerEnter(Collider other)
        {
            TriggerEnterEvent.Invoke();
        }

        private void OnCollisionEnter(Collision other)
        {
            CollisionEnterEvent.Invoke();
        }


        // Update is called once per frame
        void Update()
        {
            updateEvent.Invoke();
        }
    }
}
