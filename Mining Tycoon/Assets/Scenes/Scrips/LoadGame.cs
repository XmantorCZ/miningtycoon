using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    public int savedStats;
    public int savedCoal;
    public int savedCopper;
    public int savedIron;
    public int savedSilver;
    public int savedGold;

    void Start()
    {
        if (StartTheGame.isLoading == true) { 
            
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
    }
    }

    
}
