using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceforIron : MonoBehaviour
{
    public GameObject IronPrice;
    public int genIron;
    public GameObject IronZajemText;
    public static int Number;
    public int IronGrow;
    public bool smyc = false;
    void Start()
    {
        genIron = 15;
        

    }

    void Update()
    {
        Number = Random.Range(1, 100);

        if (smyc == false)
        {

            smyc = true;
            IronGrow = Random.Range(0, 2);

            Number = Random.Range(1, 100);

            IronZajemText.GetComponent<Text>().text = "" + Number;
            if (IronGrow == 0)
            {
                
                if (genIron <= 1)
                {
                    genIron += 1;

                    IronPrice.GetComponent<Text>().text = "$" + genIron + "  +";
                }
                if (genIron > 1)
                {
                    genIron -= 1;

                    IronPrice.GetComponent<Text>().text = "$" + genIron + "  -";
                    StartCoroutine(Odpocet());
                }



            }
            if (IronGrow == 1)
            {
                genIron += 1;

                IronPrice.GetComponent<Text>().text = "$" + genIron + "  +";
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
