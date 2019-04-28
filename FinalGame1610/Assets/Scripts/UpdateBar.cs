using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;
using UnityEngine.UI;

//Integrated from School lessons
public class UpdateBar : MonoBehaviour
{
    public Image barImage;
    public FloatSobjData fillNumber;

    void Update()
    {
        barImage.fillAmount = fillNumber.Value;
    }
}
