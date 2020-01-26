using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceforSilver : MonoBehaviour
{
    public GameObject SilverPrice;
    
    public int genSilver;
    public GameObject SilverZajemText;
    public static int Number;

    public int SilverGrow;
    
    public bool smyc = false;
    void Start()
    {
        genSilver = 25;
        

    }

    void Update()
    {
        if (smyc == false)
        {

            smyc = true;
            SilverGrow = Random.Range(0, 2);
            Number = Random.Range(1, 100);

            SilverZajemText.GetComponent<Text>().text = "" + Number;


            if (SilverGrow == 0)
            {
                
                if (genSilver <= 1)
                {
                    genSilver += 1;

                    SilverPrice.GetComponent<Text>().text = "$" + genSilver + "  +";
                }
                if (genSilver > 1)
                {
                    genSilver -= 1;

                    SilverPrice.GetComponent<Text>().text = "$" + genSilver + "  -";
                    StartCoroutine(Odpocet());
                }



            }
            if (SilverGrow == 1)
            {
                genSilver += 1;

                SilverPrice.GetComponent<Text>().text = "$" + genSilver + "  +";
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
