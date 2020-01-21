using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveGame : MonoBehaviour
{
    
    
    public void SaveTheGame()
    {
        PlayerPrefs.SetInt("SavedClicks", GlobalClicks.ClicksCount);
        PlayerPrefs.SetInt("SavedCoal", GlobalCoal.CoalCount);
        PlayerPrefs.SetInt("SavedCopper", GlobalCopper.CopperCount);
        PlayerPrefs.SetInt("SavedIron", GlobalIron.IronCount);
        PlayerPrefs.SetInt("SavedSilver", GlobalSilver.SilverCount);
        PlayerPrefs.SetInt("SavedGold", GlobalGold.GoldCount);

        SceneManager.LoadScene(0); 

    }
}
