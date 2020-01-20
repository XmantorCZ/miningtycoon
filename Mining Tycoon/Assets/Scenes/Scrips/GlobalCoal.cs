using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalCoal : MonoBehaviour
{
    public GameObject CoalDisplay;
    public static int CoalCount;
    public int InternalCount;

    void Update()
    {
        InternalCount = CoalCount;
        CoalDisplay.GetComponent<Text>().text = "" + CoalCount;
    }
}
