using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rock : MonoBehaviour
{

    public int genChance;
    public static int Stats;
    public GameObject StatBra;
    public GameObject CoalAnimat;
    public GameObject IronAnimat;
    public GameObject GoldAnimat;
    public GameObject CopperAnimat;
    public GameObject SilverAnimat;


    public void ClickTheButton()
    {
        genChance = Random.Range(1, 100);
        Stats += 1;
        StatBra.GetComponent<Text>().text = "" + Stats;
        if(genChance < 40)
        {

        }
        if(genChance >= 40 && genChance < 65)
        {
            GlobalCoal.CoalCount += 1;
            CoalAnimat.GetComponent<Animation>().Play("CoalAnimation");
        }
        if(genChance >= 65 & genChance < 80)
        {
            GlobalCopper.CopperCount += 1;
            CopperAnimat.GetComponent<Animation>().Play("CopperAnimation");
        }
        if(genChance >= 80 && genChance < 90)
        {
            GlobalIron.IronCount += 1;
            IronAnimat.GetComponent<Animation>().Play("IronAnimation");
        }
        if(genChance >= 90 && genChance < 95)
        {
            GlobalGold.GoldCount += 1;
            GoldAnimat.GetComponent<Animation>().Play("GoldAnimation");
        }
        if (genChance >= 95)
        {
            GlobalSilver.SilverCount += 1;
            SilverAnimat.GetComponent<Animation>().Play("SilverAnimation");
        }
    }
}
