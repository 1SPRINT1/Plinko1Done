using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSystem : MonoBehaviour
{
    public AudioSource[] AU;
    public int SoundStatus;
    public bool isStatus;
  //  public Text StatusText;

    private void Start()
    {
        SoundStatus = PlayerPrefs.GetInt("Sound", SoundStatus);
        if (SoundStatus == 1)
        {
            isStatus = false;
        }
        if (SoundStatus == 0)
        {
            isStatus = true;
        }
    }

    private void Update()
    {
        SoundStatus = PlayerPrefs.GetInt("Sound", SoundStatus);
        if (isStatus == false)
        {
            SoundStatus = 1;
        }
        if (isStatus == true)
        {
            SoundStatus = 0;
        }
        PlayerPrefs.SetInt("Sound",SoundStatus);
        if (isStatus == false)
        {
         //   StatusText.text = "Sound Status: OFF";
         AU = FindObjectsOfType<AudioSource>();
            for (int i = 0; i < AU.Length; i++)
            {
                AU[i].mute = true;
                AU[i].volume = 0f;
            }
        }

        if (isStatus == true)
        {
        //    StatusText.text = "Sound Status: ON";
        AU = FindObjectsOfType<AudioSource>();
            for (int i = 0; i < AU.Length; i++)
            {
                AU[i].mute = false;
                AU[i].volume = 0.4f;
            }
        }
    }

    public void OnSound()
    {
        SoundStatus = 0;
        PlayerPrefs.SetInt("Sound",SoundStatus);
    }

    public void OffSound()
    {
        SoundStatus = 1;
        PlayerPrefs.SetInt("Sound",SoundStatus);
    }

    public void UniversalSound()
    {
        isStatus = !isStatus;
    }
}
