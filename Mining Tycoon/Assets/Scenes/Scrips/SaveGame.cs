using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveGame : MonoBehaviour
{
    
    
    public void SaveTheGame()
    {
        PlayerPrefs.SetInt("OverSound", SetVolume.Soundover);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("Volume", SetVolume.musicVolume);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("Over", StartTheGame.over);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("SavedClicks", GlobalClicks.ClicksCount);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("SavedCoal", GlobalCoal.CoalCount);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("SavedCopper", GlobalCopper.CopperCount);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("SavedIron", GlobalIron.IronCount);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("SavedSilver", GlobalSilver.SilverCount);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("SavedGold", GlobalGold.GoldCount);
        PlayerPrefs.Save();

        SceneManager.LoadScene(0);



    }
}
