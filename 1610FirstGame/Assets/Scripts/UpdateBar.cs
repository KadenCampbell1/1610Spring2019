using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class UpdateBar : MonoBehaviour
{
    public Image barImage;
    public FloatData fillNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        //barImage.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        barImage.fillAmount = fillNumber.Value;
    }
}
