using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalGold : MonoBehaviour
{
    public GameObject GoldDisplay;
    public static int GoldCount;
    public int InternalCount;

    void Update()
    {
        InternalCount = GoldCount;
        GoldDisplay.GetComponent<Text>().text = "" + GoldCount;
    }
}
