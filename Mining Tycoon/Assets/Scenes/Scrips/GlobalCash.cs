using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public GameObject Cash;
    public static float CountCash;

    void Update()
    {
        Cash.GetComponent<Text>().text = "" + CountCash;   
    }
}
