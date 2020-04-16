//
//  Game Name: AvatarClash
//  Source File Name : MusicController.cs
//  Author’s Name : Dipal Patel (301090880), Loveleen Kaur (301093331) , Bhavya Shah (301076681)
//  Date Last Modified : 13 April 2020
//  Program Description : Control the sound on/off operation
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    private AudioController music;
    public Button musicButtonToggle;

    public Sprite musicOnSprite;
    public Sprite musicOffSprite;

    // Start is called before the first frame update
    void Start()
    {
        music = GameObject.FindObjectOfType<AudioController>();
        UpdateIconAndAudio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // function for stoping the sound
    public void PauseMusic()
    {
        music.ToggleSound(); // update players pref
        UpdateIconAndAudio();
    }

    // on toggle update sound and buttons
    void UpdateIconAndAudio()
    {
        if(PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            AudioListener.volume = 1;
            musicButtonToggle.GetComponent<Image>().sprite = musicOnSprite;
        }
        else
        {
            AudioListener.volume = 0;
            musicButtonToggle.GetComponent<Image>().sprite = musicOffSprite;
        }
    }
}
