using UnityEngine;
using UnityEngine.Events;

namespace DnD.DnDScripts
{
    public class DnDMonoEvents : MonoBehaviour
    {
        //make a DNDFunctions script
    
        public UnityEvent onClickEvent;

        private void OnMouseDown()
        {
            onClickEvent.Invoke();
        }
    }
}
