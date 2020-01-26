using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PriceforCoal : MonoBehaviour
{
    public GameObject CoalPrice;
    public static int genCoal;
    public int CoalGrow;
    public GameObject CoalZajemText;
    public static int Number;
    public bool smyc = false;
    

    
    void Start()
    {
        genCoal = 5;
        

    }

    void Update()
    {
        if (smyc == false)
        {
            smyc = true;
            CoalGrow = Random.Range(0, 2);
            Number = Random.Range(1, 100);

            CoalZajemText.GetComponent<Text>().text = "" + Number;

            if (CoalGrow == 0)
            {
                
                if (genCoal <= 1)
                {
                    genCoal += 1;
                    
                    CoalPrice.GetComponent<Text>().text = "$" + genCoal;
                    CoalPrice.GetComponent<Text>().color = Color.green;
                    StartCoroutine(Odpocet());
                }
                if (genCoal > 1)
                {
                    genCoal -= 1;
                    
                    CoalPrice.GetComponent<Text>().text = "$" + genCoal;
                    CoalPrice.GetComponent<Text>().color = Color.red;
                    StartCoroutine(Odpocet());
                }



            }
            if (CoalGrow == 1)
            {
                genCoal += 1;
                
                CoalPrice.GetComponent<Text>().text = "$" + genCoal;
                CoalPrice.GetComponent<Text>().color = Color.green;
                StartCoroutine(Odpocet());

            }

        }



    }

    IEnumerator Odpocet()
    {
        yield return new WaitForSeconds(30);

        smyc = false;


    }

    
}
