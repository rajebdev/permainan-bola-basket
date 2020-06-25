using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerakTambahanController : MonoBehaviour
{

    public GameObject menu;
    public GameObject layup, layupCara, layupGambar, layupVideo;
    public GameObject shooting, shootingCara, shootingGambar, shootingVideo;
    public GameObject pivot, pivotCara, pivotGambar, pivotVideo;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toHome()
    {
        SceneManager.LoadScene("Menu");
    }

    public void toGerakDasar()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("Materi");
        PlayerPrefs.SetInt("GerakDasar", 1);
    }

    public GameObject keluar;

    public void toKeluar()
    {
        new ButtonEffectController().onClick();
        keluar.SetActive(true);
    }

    public void toGerakTambahan()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(true);
        layup.SetActive(false);
        layupCara.SetActive(false);
        layupGambar.SetActive(false);
        layupVideo.SetActive(false);
        shooting.SetActive(false);
        shootingCara.SetActive(false);
        shootingGambar.SetActive(false);
        shootingVideo.SetActive(false);
        pivot.SetActive(false);
        pivotCara.SetActive(false);
        pivotGambar.SetActive(false);
        pivotVideo.SetActive(false);
    }

    public void toLayup()
    {
        PlayerPrefs.SetInt("music", 1);
        GameObject bgm = GameObject.Find("BGM");
        bgm.GetComponent<AudioSource>().Play();
        new ButtonEffectController().onClick();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        layup.SetActive(true);
        layupCara.SetActive(false);
        layupGambar.SetActive(false);
        layupVideo.SetActive(false);
        shooting.SetActive(false);
        shootingCara.SetActive(false);
        shootingGambar.SetActive(false);
        shootingVideo.SetActive(false);
        pivot.SetActive(false);
        pivotCara.SetActive(false);
        pivotGambar.SetActive(false);
        pivotVideo.SetActive(false);
    }

    public void toLayupCara()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        layup.SetActive(false);
        layupCara.SetActive(true);
        layupGambar.SetActive(false);
        layupVideo.SetActive(false);
        shooting.SetActive(false);
        shootingCara.SetActive(false);
        shootingGambar.SetActive(false);
        shootingVideo.SetActive(false);
        pivot.SetActive(false);
        pivotCara.SetActive(false);
        pivotGambar.SetActive(false);
        pivotVideo.SetActive(false);
    }

    public void toLayupGambar()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        layup.SetActive(false);
        layupCara.SetActive(false);
        layupGambar.SetActive(true);
        layupVideo.SetActive(false);
        shooting.SetActive(false);
        shootingCara.SetActive(false);
        shootingGambar.SetActive(false);
        shootingVideo.SetActive(false);
        pivot.SetActive(false);
        pivotCara.SetActive(false);
        pivotGambar.SetActive(false);
        pivotVideo.SetActive(false);
    }

    public void toLayupVideo()
    {
        new ButtonSoundController().OnOffMusic();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        layup.SetActive(false);
        layupCara.SetActive(false);
        layupGambar.SetActive(false);
        layupVideo.SetActive(true);
        shooting.SetActive(false);
        shootingCara.SetActive(false);
        shootingGambar.SetActive(false);
        shootingVideo.SetActive(false);
        pivot.SetActive(false);
        pivotCara.SetActive(false);
        pivotGambar.SetActive(false);
        pivotVideo.SetActive(false);
    }

    public void toShooting()
    {
        PlayerPrefs.SetInt("music", 1);
        GameObject bgm = GameObject.Find("BGM");
        bgm.GetComponent<AudioSource>().Play();
        new ButtonEffectController().onClick();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        layup.SetActive(false);
        layupCara.SetActive(false);
        layupGambar.SetActive(false);
        layupVideo.SetActive(false);
        shooting.SetActive(true);
        shootingCara.SetActive(false);
        shootingGambar.SetActive(false);
        shootingVideo.SetActive(false);
        pivot.SetActive(false);
        pivotCara.SetActive(false);
        pivotGambar.SetActive(false);
        pivotVideo.SetActive(false);
    }

    public void toShootingCara()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        layup.SetActive(false);
        layupCara.SetActive(false);
        layupGambar.SetActive(false);
        layupVideo.SetActive(false);
        shooting.SetActive(false);
        shootingCara.SetActive(true);
        shootingGambar.SetActive(false);
        shootingVideo.SetActive(false);
        pivot.SetActive(false);
        pivotCara.SetActive(false);
        pivotGambar.SetActive(false);
        pivotVideo.SetActive(false);
    }

    public void toShootingGambar()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        layup.SetActive(false);
        layupCara.SetActive(false);
        layupGambar.SetActive(false);
        layupVideo.SetActive(false);
        shooting.SetActive(false);
        shootingCara.SetActive(false);
        shootingGambar.SetActive(true);
        shootingVideo.SetActive(false);
        pivot.SetActive(false);
        pivotCara.SetActive(false);
        pivotGambar.SetActive(false);
        pivotVideo.SetActive(false);
    }

    public void toShootingVideo()
    {
        new ButtonSoundController().OnOffMusic();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        layup.SetActive(false);
        layupCara.SetActive(false);
        layupGambar.SetActive(false);
        layupVideo.SetActive(false);
        shooting.SetActive(false);
        shootingCara.SetActive(false);
        shootingGambar.SetActive(false);
        shootingVideo.SetActive(true);
        pivot.SetActive(false);
        pivotCara.SetActive(false);
        pivotGambar.SetActive(false);
        pivotVideo.SetActive(false);
    }

    public void toPivot()
    {
        PlayerPrefs.SetInt("music", 1);
        GameObject bgm = GameObject.Find("BGM");
        bgm.GetComponent<AudioSource>().Play();
        new ButtonEffectController().onClick();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        layup.SetActive(false);
        layupCara.SetActive(false);
        layupGambar.SetActive(false);
        layupVideo.SetActive(false);
        shooting.SetActive(false);
        shootingCara.SetActive(false);
        shootingGambar.SetActive(false);
        shootingVideo.SetActive(false);
        pivot.SetActive(true);
        pivotCara.SetActive(false);
        pivotGambar.SetActive(false);
        pivotVideo.SetActive(false);
    }

    public void toPivotCara()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        layup.SetActive(false);
        layupCara.SetActive(false);
        layupGambar.SetActive(false);
        layupVideo.SetActive(false);
        shooting.SetActive(false);
        shootingCara.SetActive(false);
        shootingGambar.SetActive(false);
        shootingVideo.SetActive(false);
        pivot.SetActive(false);
        pivotCara.SetActive(true);
        pivotGambar.SetActive(false);
        pivotVideo.SetActive(false);
    }

    public void toPivotGambar()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        layup.SetActive(false);
        layupCara.SetActive(false);
        layupGambar.SetActive(false);
        layupVideo.SetActive(false);
        shooting.SetActive(false);
        shootingCara.SetActive(false);
        shootingGambar.SetActive(false);
        shootingVideo.SetActive(false);
        pivot.SetActive(false);
        pivotCara.SetActive(false);
        pivotGambar.SetActive(true);
        pivotVideo.SetActive(false);
    }

    public void toPivotVideo()
    {
        new ButtonSoundController().OnOffMusic();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        layup.SetActive(false);
        layupCara.SetActive(false);
        layupGambar.SetActive(false);
        layupVideo.SetActive(false);
        shooting.SetActive(false);
        shootingCara.SetActive(false);
        shootingGambar.SetActive(false);
        shootingVideo.SetActive(false);
        pivot.SetActive(false);
        pivotCara.SetActive(false);
        pivotGambar.SetActive(false);
        pivotVideo.SetActive(true);
    }
}
