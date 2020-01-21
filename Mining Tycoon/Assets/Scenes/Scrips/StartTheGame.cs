using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTheGame : MonoBehaviour
{
    

    public int savedStats;
    public int savedCoal;
    public int savedCopper;
    public int savedIron;
    public int savedSilver;
    public int savedGold;
    public static int over;

    public void NewGame()
    {
        over = 1;
        GlobalClicks.ClicksCount = 0;
        GlobalCoal.CoalCount = 0;
        GlobalCopper.CopperCount = 0;
        GlobalIron.IronCount = 0;
        GlobalSilver.SilverCount = 0;
        GlobalGold.GoldCount = 0;

        SceneManager.LoadScene(2);
    }
    public void LoadGame()
    {
        if (over == 1) { 
        savedStats = PlayerPrefs.GetInt("SavedClicks");
        GlobalClicks.ClicksCount = savedStats;

        savedCoal = PlayerPrefs.GetInt("SavedCoal");
        GlobalCoal.CoalCount = savedCoal;

        savedCopper = PlayerPrefs.GetInt("SavedCopper");
        GlobalCopper.CopperCount = savedCopper;

        savedIron = PlayerPrefs.GetInt("SavedIron");
        GlobalIron.IronCount = savedIron;

        savedSilver = PlayerPrefs.GetInt("SavedSilver");
        GlobalSilver.SilverCount = savedSilver;

        savedGold = PlayerPrefs.GetInt("SavedGold");
        GlobalGold.GoldCount = savedGold;

        SceneManager.LoadScene(1);
    }if(over != 1)
        {

        }
    }

}

