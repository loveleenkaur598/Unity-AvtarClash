//
//  Game Name: AvatarClash
//  Source File Name : AudioController.cs
//  Author’s Name : Dipal Patel (301090880), Loveleen Kaur (301093331) , Bhavya Shah (301076681)
//  Date Last Modified : 13 April 2020
//  Program Description : Control the sound on/off operation
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    static AudioController instance = null;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    // toggle the sound on button click
    public void ToggleSound()
    {
        if(PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            PlayerPrefs.SetInt("Muted", 1);
            //AudioListner.volume = 1
        }
        else
        {
            PlayerPrefs.SetInt("Muted", 0);
            //AudioListner.volume = 1
        }
    }
}
