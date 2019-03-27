using UnityEngine;

namespace TodayScripts
{
    public class FunctionsWithPerams : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            AddData(12.5f, 8.5f);
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void AddData(float a, float b)
        {
            print(a + b);
        }

        private void OnTriggerEnter(Collider obj)
        {
            obj.gameObject.SetActive(false);
        }
    }
}
