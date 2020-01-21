using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalClicks : MonoBehaviour
{

    public GameObject StatsDisplay;
    public static int ClicksCount;
    public int InternalCount;

    void Update()
    {
        InternalCount = ClicksCount;
        StatsDisplay.GetComponent<Text>().text = "" + ClicksCount;
    }
}
