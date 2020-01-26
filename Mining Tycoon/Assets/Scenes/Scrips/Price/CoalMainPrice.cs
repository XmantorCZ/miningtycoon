using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoalMainPrice : MonoBehaviour
{
    public GameObject CoalMoney;
    public static float Prize;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Prize = CoalSlider.CoalSliderValue * PriceforCoal.genCoal;
        CoalMoney.GetComponent<Text>().text = "$" + Prize;
    }
}
