using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    private AudioSource audioSrc; 
    public static float musicVolume;
    void Start()
    {
        
        musicVolume = 0.5f;
        audioSrc = GetComponent<AudioSource>();
    }
    void Update()
    {
        PlayerPrefs.GetFloat("Volume", musicVolume);

        audioSrc.volume = musicVolume;

    }
    public void SetVolumeMusic(float vol)
    {
        musicVolume = vol;
        PlayerPrefs.SetFloat("Volume", musicVolume);
    }
}
