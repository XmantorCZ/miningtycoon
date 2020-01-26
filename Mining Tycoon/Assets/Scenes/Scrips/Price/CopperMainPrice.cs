using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopperMainPrice : MonoBehaviour
{
    public GameObject CopperMoney;
    public static float CopperPrize;

    // Update is called once per frame
    void Update()
    {
        
            CopperPrize = CopperSlider.CopperSliderValue * PriceforCopper.genCopper;
            CopperMoney.GetComponent<Text>().text = "$" + CopperPrize;
        
    }
}
