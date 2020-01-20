using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalCopper : MonoBehaviour
{
    public GameObject CopperDisplay;
    public static int CopperCount;
    public int InternalCount;

    void Update()
    {
        InternalCount = CopperCount;
        CopperDisplay.GetComponent<Text>().text = "" + CopperCount;
    }
}
