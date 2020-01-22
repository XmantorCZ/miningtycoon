using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    
    private AudioSource audioSrc;
    public static float musicVolume;
    public static int Soundover;
    public Slider SliderVolume;
    public Toggle Tlacitko;
    public int Muted;
    
    void Start()
    {
        Soundover = PlayerPrefs.GetInt("OverSound");
        if (Soundover != 1)
        {
            musicVolume = 0.5f;
        }
        if (Soundover == 1)
        {
            musicVolume = PlayerPrefs.GetFloat("Volume");
        }
    
    SliderVolume.value = musicVolume;
    audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        
            audioSrc.volume = musicVolume;
        
    }
    public void SetVolumeMusic(float vol)
    {

        
        musicVolume = vol;    
        Soundover = 1;

        }

    public void Mute()
    {
        
            musicVolume = 0;
            SliderVolume.value = 0;
           
        }
    }

    




