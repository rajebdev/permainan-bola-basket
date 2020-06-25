using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerakPokokController : MonoBehaviour
{
    public GameObject menu;
    public GameObject menggiring, caraMenggiring, gambarMenggiring, videoMenggiring;
    public GameObject menangkap, caraMenangkap, gambarMenangkap, videoMenangkap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject keluar;

    public void toKeluar()
    {
        new ButtonEffectController().onClick();
        keluar.SetActive(true);
    }

    public void toHome()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("Menu");
    }

    public void toGerakDasar()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("Materi");
        PlayerPrefs.SetInt("GerakDasar", 1);
    }

    public void toGerakPokok()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(true);
        menggiring.SetActive(false);
        caraMenggiring.SetActive(false);
        gambarMenggiring.SetActive(false);
        videoMenggiring.SetActive(false);
        menangkap.SetActive(false);
        caraMenangkap.SetActive(false);
        gambarMenangkap.SetActive(false);
        videoMenangkap.SetActive(false);
    }

    public void toMenggiring()
    {
        PlayerPrefs.SetInt("music", 1);
        GameObject bgm = GameObject.Find("BGM");
        bgm.GetComponent<AudioSource>().Play();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        menggiring.SetActive(true);
        caraMenggiring.SetActive(false);
        gambarMenggiring.SetActive(false);
        videoMenggiring.SetActive(false);
        menangkap.SetActive(false);
        caraMenangkap.SetActive(false);
        gambarMenangkap.SetActive(false);
        videoMenangkap.SetActive(false);
    }
    public void toCaraMenggiring()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        menggiring.SetActive(false);
        caraMenggiring.SetActive(true);
        gambarMenggiring.SetActive(false);
        videoMenggiring.SetActive(false);
        menangkap.SetActive(false);
        caraMenangkap.SetActive(false);
        gambarMenangkap.SetActive(false);
        videoMenangkap.SetActive(false);
    }
    public void toGambarMenggiring()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        menggiring.SetActive(false);
        caraMenggiring.SetActive(false);
        gambarMenggiring.SetActive(true);
        videoMenggiring.SetActive(false);
        menangkap.SetActive(false);
        caraMenangkap.SetActive(false);
        gambarMenangkap.SetActive(false);
        videoMenangkap.SetActive(false);
    }
    public void toVideoMenggiring()
    {
        new ButtonSoundController().OnOffMusic();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        menggiring.SetActive(false);
        caraMenggiring.SetActive(false);
        gambarMenggiring.SetActive(false);
        videoMenggiring.SetActive(true);
        menangkap.SetActive(false);
        caraMenangkap.SetActive(false);
        gambarMenangkap.SetActive(false);
        videoMenangkap.SetActive(false);
    }
    public void toMenangkap()
    {
        PlayerPrefs.SetInt("music", 1);
        GameObject bgm = GameObject.Find("BGM");
        bgm.GetComponent<AudioSource>().Play();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        menggiring.SetActive(false);
        caraMenggiring.SetActive(false);
        gambarMenggiring.SetActive(false);
        videoMenggiring.SetActive(false);
        menangkap.SetActive(true);
        caraMenangkap.SetActive(false);
        gambarMenangkap.SetActive(false);
        videoMenangkap.SetActive(false);
    }
    public void toCaraMenangkap()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        menggiring.SetActive(false);
        caraMenggiring.SetActive(false);
        gambarMenggiring.SetActive(false);
        videoMenggiring.SetActive(false);
        menangkap.SetActive(false);
        caraMenangkap.SetActive(true);
        gambarMenangkap.SetActive(false);
        videoMenangkap.SetActive(false);
    }
    public void toGambarMenangkap()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        menggiring.SetActive(false);
        caraMenggiring.SetActive(false);
        gambarMenggiring.SetActive(false);
        videoMenggiring.SetActive(false);
        menangkap.SetActive(false);
        caraMenangkap.SetActive(false);
        gambarMenangkap.SetActive(true);
        videoMenangkap.SetActive(false);
    }
    
    public void toVideoMenangkap()
    {
        new ButtonSoundController().OnOffMusic();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        menggiring.SetActive(false);
        caraMenggiring.SetActive(false);
        gambarMenggiring.SetActive(false);
        videoMenggiring.SetActive(false);
        menangkap.SetActive(false);
        caraMenangkap.SetActive(false);
        gambarMenangkap.SetActive(false);
        videoMenangkap.SetActive(true);
    }

    public void toMelempar()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("Melempar");
    }
}
