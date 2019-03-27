using UnityEngine;

namespace DailyScripts
{
    public class LightChecker : MonoBehaviour
    {
        public bool activateLight2;

        public Light myLight;
        // Start is called before the first frame update
        void Start()
        {
            //connect activateLight2 to activateLight in the Lightswitch script
            //activateLight2 = gameObject.GetComponent<Lightswitch>().activateLight;
            myLight = gameObject.GetComponent<Light>();
        }

        // Update is called once per frame
        void Update()
        {
            if (activateLight2)
            {
                myLight.enabled = false;
            }
            else
            {
                myLight.enabled = true;
            }
        }
    }
}
