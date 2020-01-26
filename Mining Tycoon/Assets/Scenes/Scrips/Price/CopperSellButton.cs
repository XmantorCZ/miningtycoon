using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopperSellButton : MonoBehaviour
{
    public Slider SliderCopper;
    public GameObject CopperButton;
    public GameObject CopperProcenta;
    public GameObject CopperSekundy;
    public static int Copperstart;
    public static float Coppera;
    public static float Copperb;

    void Start()
    {
        CopperButton.SetActive(true);
        CopperProcenta.SetActive(false);
        CopperSekundy.SetActive(false);
    }


    public void Sell()
    {
        if (CopperSlider.CopperSliderValue > GlobalCopper.CopperCount)
        {

        }
        if (CopperSlider.CopperSliderValue <= GlobalCopper.CopperCount)
        {
            SliderCopper.interactable = false;
            CopperButton.SetActive(false);
            CopperProcenta.SetActive(true);
            CopperSekundy.SetActive(true);
            Coppera = (100 - PriceforCopper.Number) / 2;
            Copperb = Coppera / 4;
            StartCoroutine(CopperCas());

        }
    }
    


    public IEnumerator CopperCas()
{
        CopperButton.SetActive(false);
        CopperProcenta.SetActive(true);
        CopperSekundy.SetActive(true);
        CopperProcenta.GetComponent<Text>().text = "0%";
        CopperSekundy.GetComponent<Text>().text = "" + Coppera;
    yield return new WaitForSeconds(Copperb);
        CopperProcenta.GetComponent<Text>().text = "25%";
        Coppera = Coppera - Copperb;
        CopperSekundy.GetComponent<Text>().text = "" + Coppera;
    yield return new WaitForSeconds(Copperb);
        CopperProcenta.GetComponent<Text>().text = "50%";
        Coppera = Coppera - Copperb;
        CopperSekundy.GetComponent<Text>().text = "" + Coppera;
    yield return new WaitForSeconds(Copperb);
        CopperProcenta.GetComponent<Text>().text = "75%";
        Coppera = Coppera - Copperb;
        CopperSekundy.GetComponent<Text>().text = "" + Coppera;
    yield return new WaitForSeconds(Copperb);
        CopperSekundy.GetComponent<Text>().text = "0";
        CopperProcenta.GetComponent<Text>().text = "100%";

    GlobalCash.CountCash += CopperMainPrice.CopperPrize;
    GlobalCopper.CopperCount -= (int)CopperSlider.CopperSliderValue;
        CopperButton.SetActive(true);
        CopperProcenta.SetActive(false);
        CopperSekundy.SetActive(false);
        SliderCopper.interactable = true;
}
}
      
    

