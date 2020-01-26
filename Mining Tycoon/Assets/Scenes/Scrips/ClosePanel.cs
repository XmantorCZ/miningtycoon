using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePanel : MonoBehaviour
{
    public GameObject PanelSelll;
    
    void Start()
    {
        PanelSelll.SetActive(false);
    }

    // Update is called once per frame
   public void OtevritSell()
    {
        PanelSelll.SetActive(true);
    }

    public void ZavritSell()
    {
        PanelSelll.SetActive(false);
    }
}
