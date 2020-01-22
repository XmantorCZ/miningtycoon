using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTheGame : MonoBehaviour
{

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
}
    
    


