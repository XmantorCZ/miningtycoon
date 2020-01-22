using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarningPanel : MonoBehaviour
{
    public GameObject Warning;

    void Start()
    {
        Warning.SetActive(false);
    }


    public void No()
    {
        Warning.SetActive(false);
    }

    public void Cliked()
    {
        if (StartTheGame.over == 1)
        {
            Warning.SetActive(true);
        }
        if (StartTheGame.over == 0)
        {
            StartTheGame.over = 1;
            GlobalClicks.ClicksCount = 0;
            GlobalCoal.CoalCount = 0;
            GlobalCopper.CopperCount = 0;
            GlobalIron.IronCount = 0;
            GlobalSilver.SilverCount = 0;
            GlobalGold.GoldCount = 0;

            SceneManager.LoadScene(2);
        }
    }
    
}
