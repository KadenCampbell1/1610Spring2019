﻿using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;
using UnityEngine.UI;

//Integrated from School lessons
public class UpdateText : MonoBehaviour
{
    public Text myText;
    public FloatSobjData myValue;

    private void Update()
    {
        myText.text = "Score: " + myValue.Value;
    }
}
