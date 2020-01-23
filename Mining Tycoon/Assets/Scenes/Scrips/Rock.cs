using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rock : MonoBehaviour
{

    public int genChance;
    public GameObject CoalAnimat;
    public GameObject IronAnimat;
    public GameObject GoldAnimat;
    public GameObject CopperAnimat;
    public GameObject SilverAnimat;
    public int r;

    public void ClickTheButton()
    {
        GlobalClicks.ClicksCount += 1;
        genChance = Random.Range(1, 1000);
        if(genChance < 525)
        {

        }
        if(genChance >= 525 && genChance < 700)
        {
            GlobalCoal.CoalCount += 1;
            CoalAnimat.GetComponent<Animation>().Play("CoalAnimation");
        }
        if(genChance >= 700 & genChance < 825)
        {
            GlobalCopper.CopperCount += 1;
            CopperAnimat.GetComponent<Animation>().Play("CopperAnimation");
        }
        if(genChance >= 825 && genChance < 925)
        {
            GlobalIron.IronCount += 1;
            IronAnimat.GetComponent<Animation>().Play("IronAnimation");
        }
        if(genChance >= 925 && genChance < 950)
        {
            GlobalGold.GoldCount += 1;
            GoldAnimat.GetComponent<Animation>().Play("GoldAnimation");
        }
        if (genChance >= 950)
        {
            GlobalSilver.SilverCount += 1;
            SilverAnimat.GetComponent<Animation>().Play("SilverAnimation");
        }
    }
}
