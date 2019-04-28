using UnityEngine;

//Integrated from School
namespace ScriptableObjectScripts
{
    [CreateAssetMenu]
    public class FloatSobjData : ScriptableObject
    {
        [SerializeField] private float value;

        public float Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public void UpdateValue(float floatInput)
        {
            Value += floatInput;
        }

        public void UpdateVoid(FloatSobjData dataObject)
        {
            Value += dataObject.Value;
        }
    }
}
