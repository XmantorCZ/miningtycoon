using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoalSlider : MonoBehaviour
{

    public GameObject CoalSliderText;
    public static float CoalSliderValue;

    

    void Start()
    {
        CoalSliderValue = 0;
    }

    void Update()
    {
        CoalSliderText.GetComponent<Text>().text = "" + CoalSliderValue;
    }

    public void ChangeValue(float vol)
    {
        CoalSliderValue = vol;




    }
}
