using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalSilver : MonoBehaviour
{
    public GameObject SilverDisplay;
    public static int SilverCount;
    public int InternalCount;

    void Update()
    {
        InternalCount = SilverCount;
        SilverDisplay.GetComponent<Text>().text = "" + SilverCount;
    }
}
