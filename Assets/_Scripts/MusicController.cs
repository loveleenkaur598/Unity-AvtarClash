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
        UpdateIconAndIcon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseMusic()
    {
        music.ToggleSound(); // update players pref
        UpdateIconAndIcon();
    }

    void UpdateIconAndIcon()
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
