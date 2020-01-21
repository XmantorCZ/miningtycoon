using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVolumeMining : MonoBehaviour
{
    private AudioSource soundtrack;

    void Start()
    {
        soundtrack = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        soundtrack.volume = SetVolume.musicVolume;
    }
}
