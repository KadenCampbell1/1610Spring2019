﻿using UnityEngine;

namespace ImportantScripts
{
    [CreateAssetMenu]
    public class FloatData : ScriptableObject
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

        public void UpdateVoid(FloatData dataObject)
        {
            Value += dataObject.Value;
        }
    }
}
