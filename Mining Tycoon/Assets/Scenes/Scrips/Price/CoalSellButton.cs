using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoalSellButton : MonoBehaviour
{
    public Slider SliderCoal;
    public GameObject Button;
    public GameObject Procenta;
    public GameObject Sekundy;
    public static int Coalstart;
    public static float a;
    public static float b;

    void Start()
    {
        Button.SetActive(true);
        Procenta.SetActive(false);
        Sekundy.SetActive(false);
    }


    public void Sell()
    {
        if (CoalSlider.CoalSliderValue > GlobalCoal.CoalCount)
        {

        }
        if (CoalSlider.CoalSliderValue <= GlobalCoal.CoalCount)
        {
            SliderCoal.interactable = false;
            Button.SetActive(false);
            Procenta.SetActive(true);
            Sekundy.SetActive(true);
            a = (100 - PriceforCoal.Number) / 2;
            b = a / 4;
            StartCoroutine(Cas());

        }
    }
    


    public IEnumerator Cas()
{
    Button.SetActive(false);
    Procenta.SetActive(true);
    Sekundy.SetActive(true);
    Procenta.GetComponent<Text>().text = "0%";
    Sekundy.GetComponent<Text>().text = "" + a;
    yield return new WaitForSeconds(b);
    Procenta.GetComponent<Text>().text = "25%";
    a = a - b;
    Sekundy.GetComponent<Text>().text = "" + a;
    yield return new WaitForSeconds(b);
    Procenta.GetComponent<Text>().text = "50%";
    a = a - b;
    Sekundy.GetComponent<Text>().text = "" + a;
    yield return new WaitForSeconds(b);
    Procenta.GetComponent<Text>().text = "75%";
    a = a - b;
    Sekundy.GetComponent<Text>().text = "" + a;
    yield return new WaitForSeconds(b);
    Sekundy.GetComponent<Text>().text = "0";
    Procenta.GetComponent<Text>().text = "100%";

    GlobalCash.CountCash += CoalMainPrice.Prize;
    GlobalCoal.CoalCount -= (int)CoalSlider.CoalSliderValue;
    Button.SetActive(true);
    Procenta.SetActive(false);
    Sekundy.SetActive(false);
    SliderCoal.interactable = true;
}
}
      
    

