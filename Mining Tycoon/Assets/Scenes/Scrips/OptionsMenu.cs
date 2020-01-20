using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject OptionPanel;
    



    public void ClickTheButton()
    {
        OptionPanel.SetActive(true);
    }

    public void CloseThePanel()
    {
        OptionPanel.SetActive(false);
    }


}
