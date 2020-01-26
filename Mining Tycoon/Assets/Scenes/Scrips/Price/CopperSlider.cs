using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopperSlider : MonoBehaviour
{
    public GameObject CopperSliderText;
    public static float CopperSliderValue;



    void Start()
    {
        CopperSliderValue = 0;
    }

    void Update()
    {
        CopperSliderText.GetComponent<Text>().text = "" + CopperSliderValue;
    }

    public void ChangeValue(float vol)
    {
        CopperSliderValue = vol;




    }
}
