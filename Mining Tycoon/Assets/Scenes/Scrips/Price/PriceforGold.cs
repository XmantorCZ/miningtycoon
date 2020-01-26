using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceforGold : MonoBehaviour
{
    public GameObject GoldPrice;
    
    public int genGold;
    public GameObject GoldZajemText;
    public static int Number;

    public int GoldGrow;
    
    public bool smyc = false;
    void Start()
    {
        genGold = 30;
        

    }

    void Update()
    {
        if (smyc == false)
        {

            smyc = true;
            GoldGrow = Random.Range(0, 2);
            Number = Random.Range(1, 100);

            GoldZajemText.GetComponent<Text>().text = "" + Number;


            if (GoldGrow == 0)
            {
                
                if (genGold <= 1)
                {
                    genGold += 1;

                    GoldPrice.GetComponent<Text>().text = "$" + genGold + "  +";
                }
                if (genGold > 1)
                {
                    genGold -= 1;

                    GoldPrice.GetComponent<Text>().text = "$" + genGold + "  -";
                    StartCoroutine(Odpocet());
                }



            }
            if (GoldGrow == 1)
            {
                genGold += 1;

                GoldPrice.GetComponent<Text>().text = "$" + genGold + "  +";
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
