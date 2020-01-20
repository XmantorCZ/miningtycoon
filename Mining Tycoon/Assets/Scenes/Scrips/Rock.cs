using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rock : MonoBehaviour
{

    public int genChance;
    public static int Stats;
    public GameObject StatBra;

    public void ClickTheButton()
    {
        genChance = Random.Range(1, 100);
        Stats += 1;
        StatBra.GetComponent<Text>().text = "" + Stats;
        if(genChance < 50)
        {

        }if(genChance < 80 && genChance >= 50)
        {
            GlobalCoal.CoalCount += 1;
        }if(genChance < 95 && genChance >= 80)
        {
            GlobalIron.IronCount += 1;
        }if(genChance >= 95)
        {
            GlobalGold.GoldCount += 1;
        }
    }
}
