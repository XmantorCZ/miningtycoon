using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockSPace : MonoBehaviour
{
    Button buttonMe;
    public GameObject Inventer;
    public GameObject Stone;
    public Animation Bantext;
    public int a = 1;
    
    public void IllegalPressed()
    {
        buttonMe = GetComponent<Button>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
          
            Stone.SetActive(false);
            a += 1;
            Inventer.GetComponent<Text>().text = "Invalid enter. Wait " + a + " second/s.";
            StartCoroutine(Banned());
            Bantext.GetComponent<Animation>().Play("InvalidText");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            
            Stone.SetActive(false);
            a += 1;
            Inventer.GetComponent<Text>().text = "Invalid enter. Wait " + a + " second/s.";
            StartCoroutine(Banned());
            Bantext.GetComponent<Animation>().Play("InvalidText");
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
            
            Stone.SetActive(false);
            a += 1;
            Inventer.GetComponent<Text>().text = "Invalid enter. Wait " + a + " second/s.";

            StartCoroutine(Banned());
            Bantext.GetComponent<Animation>().Play("InvalidText");
        }
    }

    IEnumerator Banned()
    {
        yield return new WaitForSeconds(a);
        Stone.SetActive(true);
        
    }
}
