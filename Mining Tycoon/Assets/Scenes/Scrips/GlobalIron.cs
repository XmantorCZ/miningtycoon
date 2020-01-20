using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalIron : MonoBehaviour
{
    public GameObject IronDisplay;
    public static int IronCount;
    public int InternalCount;

    void Update()
    {
        InternalCount = IronCount;
        IronDisplay.GetComponent<Text>().text = "" + IronCount;
    }
}
