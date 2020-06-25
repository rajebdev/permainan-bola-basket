using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroController : MonoBehaviour
{
    public GameObject login, intro, introDetails;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("toIntroDetail") == 1)
        {
            toDetails();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toIntro()
    {
        new ButtonEffectController().onClick();
        login.SetActive(false);
        intro.SetActive(true);
        introDetails.SetActive(false);
    }

    public GameObject keluar;

    public void onKeluar()
    {
        new ButtonEffectController().onClick();
        keluar.SetActive(true);
    }

    public void toDetails()
    {
        new ButtonEffectController().onClick();
        login.SetActive(false);
        intro.SetActive(false);
        introDetails.SetActive(true);
    }

    public void onHome()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("Menu");
    }
}
