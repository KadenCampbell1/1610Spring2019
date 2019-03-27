using UnityEngine;

namespace DailyScripts
{
    public class NewFunctionsWithPerams : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public int AddInt(int a, int b, int c)
        {
            return a + b + c;
        }

        public float AddFloat(float a, float b)
        {
            return a + b;
        }

        public int MinusInt(int a, int b, int c)
        {
            return a - b - c;
        }

        public float MinusFloat(float a, float b)
        {
            return a - b;
        }
    }
}
