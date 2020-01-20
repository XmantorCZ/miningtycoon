using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rock : MonoBehaviour
{

    public int genChance = 0;
    public static int Stats;
    public GameObject StatBra;
    public GameObject CoalAnimat;
    public GameObject IronAnimat;
    public GameObject GoldAnimat;


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
            CoalAnimat.GetComponent<Animation>().Play("CoalAnimation");

        }
        if(genChance < 95 && genChance >= 80)
        {
            GlobalIron.IronCount += 1;
            IronAnimat.GetComponent<Animation>().Play("IronAnimation");
        }if(genChance >= 95)
        {
            GlobalGold.GoldCount += 1;
            GoldAnimat.GetComponent<Animation>().Play("GoldAnimation");
        }
    }
}
