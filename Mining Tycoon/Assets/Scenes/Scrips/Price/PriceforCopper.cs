using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceforCopper : MonoBehaviour
{
    public GameObject CopperPrice;
    
    public static int genCopper;
   
    public int CopperGrow;
    public GameObject CopperZajemText;
    public static int Number;
    public bool smyc = false;
    void Start()
    {
        genCopper = 10;
        

    }

    void Update()
    {
        if (smyc == false)
        {

            smyc = true;
            CopperGrow = Random.Range(0, 2);
            Number = Random.Range(1, 100);

            CopperZajemText.GetComponent<Text>().text = "" + Number;


            if (CopperGrow == 0)
            {
                
                if (genCopper <= 1)
                {
                    genCopper += 1;
                    
                    CopperPrice.GetComponent<Text>().text = "$" + genCopper;
                    CopperPrice.GetComponent<Text>().color = Color.green;
                }
                if (genCopper > 1)
                {
                    genCopper -= 1;
                    
                    CopperPrice.GetComponent<Text>().text = "$" + genCopper;
                    CopperPrice.GetComponent<Text>().color = Color.red;
                    StartCoroutine(Odpocet());
                }



            }
            if (CopperGrow == 1)
            {
                genCopper += 1;
                
                CopperPrice.GetComponent<Text>().text = "$" + genCopper;
                CopperPrice.GetComponent<Text>().color = Color.green;
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
