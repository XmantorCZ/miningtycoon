using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    

    void Update()
    {

        StartCoroutine(Waiting());
        
        
        
        IEnumerator Waiting()
        {
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene(1);
        }

    }
}
