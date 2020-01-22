using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public GameObject LoadButton;
    public GameObject FakeLoadButton;
    public int savedStats;
    public int savedCoal;
    public int savedCopper;
    public int savedIron;
    public int savedSilver;
    public int savedGold;
    public int overeni;
    // Start is called before the first frame update
    void Start()
    {
        LoadButton.SetActive(true);
        FakeLoadButton.SetActive(false);
        overeni = PlayerPrefs.GetInt("Over");
        StartTheGame.over = overeni;

        if (StartTheGame.over == 1)
        {
            LoadButton.SetActive(true);
            FakeLoadButton.SetActive(false);
            
            
        }
        if (StartTheGame.over != 1)
        {
            LoadButton.SetActive(false);
            FakeLoadButton.SetActive(true);
        }
    }

    // Update is called once per frame
    public void LoadButtonClick()
    {
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

        SceneManager.LoadScene(2);
    }
}
