using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSoundController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnOffMusic()
    {
        new ButtonEffectController().onClick();
        GameObject bgm = GameObject.Find("BGM");
        GameObject volumeImg = GameObject.Find("ButtonSound").transform.GetChild(0).gameObject;
        if (PlayerPrefs.GetInt("music") == 2)
        {
            PlayerPrefs.SetInt("music", 1);
            volumeImg.GetComponent<Image>().sprite = Resources.Load<Sprite>("SoundOn");
            bgm.GetComponent<AudioSource>().Play();
        }
        else if (PlayerPrefs.GetInt("music") == 1 || PlayerPrefs.GetInt("music") == 0)
        {
            PlayerPrefs.SetInt("music", 2);
            volumeImg.GetComponent<Image>().sprite = Resources.Load<Sprite>("SoundOff");
            bgm.GetComponent<AudioSource>().Pause();
        }
    }
}
