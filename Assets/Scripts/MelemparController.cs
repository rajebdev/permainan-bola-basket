using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MelemparController : MonoBehaviour
{
    public GameObject menu;
    public GameObject chest, chestCara, chestGambar, chestVideo;
    public GameObject bounce, bounceCara, bounceGambar, bounceVideo;
    public GameObject overhead, overheadCara, overheadGambar, overheadVideo;
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
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("Menu");
    }

    public void toGerakPokok()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("GerakPokok");
    }


    public GameObject keluar;

    public void toKeluar()
    {
        new ButtonEffectController().onClick();
        keluar.SetActive(true);
    }
    public void toMelempar()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(true);
        chest.SetActive(false);
        chestCara.SetActive(false);
        chestGambar.SetActive(false);
        chestVideo.SetActive(false);
        bounce.SetActive(false);
        bounceCara.SetActive(false);
        bounceGambar.SetActive(false);
        bounceVideo.SetActive(false);
        overhead.SetActive(false);
        overheadCara.SetActive(false);
        overheadGambar.SetActive(false);
        overheadVideo.SetActive(false);
    }

    public void toChest()
    {
        PlayerPrefs.SetInt("music", 1);
        GameObject bgm = GameObject.Find("BGM");
        bgm.GetComponent<AudioSource>().Play();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        chest.SetActive(true);
        chestCara.SetActive(false);
        chestGambar.SetActive(false);
        chestVideo.SetActive(false);
        bounce.SetActive(false);
        bounceCara.SetActive(false);
        bounceGambar.SetActive(false);
        bounceVideo.SetActive(false);
        overhead.SetActive(false);
        overheadCara.SetActive(false);
        overheadGambar.SetActive(false);
        overheadVideo.SetActive(false);
    }

    public void toChestCara()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        chest.SetActive(false);
        chestCara.SetActive(true);
        chestGambar.SetActive(false);
        chestVideo.SetActive(false);
        bounce.SetActive(false);
        bounceCara.SetActive(false);
        bounceGambar.SetActive(false);
        bounceVideo.SetActive(false);
        overhead.SetActive(false);
        overheadCara.SetActive(false);
        overheadGambar.SetActive(false);
        overheadVideo.SetActive(false);
    }

    public void toChestGambar()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        chest.SetActive(false);
        chestCara.SetActive(false);
        chestGambar.SetActive(true);
        chestVideo.SetActive(false);
        bounce.SetActive(false);
        bounceCara.SetActive(false);
        bounceGambar.SetActive(false);
        bounceVideo.SetActive(false);
        overhead.SetActive(false);
        overheadCara.SetActive(false);
        overheadGambar.SetActive(false);
        overheadVideo.SetActive(false);
    }

    public void toChestVideo()
    {
        new ButtonSoundController().OnOffMusic();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        chest.SetActive(false);
        chestCara.SetActive(false);
        chestGambar.SetActive(false);
        chestVideo.SetActive(true);
        bounce.SetActive(false);
        bounceCara.SetActive(false);
        bounceGambar.SetActive(false);
        bounceVideo.SetActive(false);
        overhead.SetActive(false);
        overheadCara.SetActive(false);
        overheadGambar.SetActive(false);
        overheadVideo.SetActive(false);
    }

    public void toBounce()
    {
        PlayerPrefs.SetInt("music", 1);
        GameObject bgm = GameObject.Find("BGM");
        bgm.GetComponent<AudioSource>().Play();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        chest.SetActive(false);
        chestCara.SetActive(false);
        chestGambar.SetActive(false);
        chestVideo.SetActive(false);
        bounce.SetActive(true);
        bounceCara.SetActive(false);
        bounceGambar.SetActive(false);
        bounceVideo.SetActive(false);
        overhead.SetActive(false);
        overheadCara.SetActive(false);
        overheadGambar.SetActive(false);
        overheadVideo.SetActive(false);
    }

    public void toBounceCara()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(true);
        chest.SetActive(false);
        chestCara.SetActive(false);
        chestGambar.SetActive(false);
        chestVideo.SetActive(false);
        bounce.SetActive(false);
        bounceCara.SetActive(true);
        bounceGambar.SetActive(false);
        bounceVideo.SetActive(false);
        overhead.SetActive(false);
        overheadCara.SetActive(false);
        overheadGambar.SetActive(false);
        overheadVideo.SetActive(false);
    }

    public void toBounceGambar()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        chest.SetActive(false);
        chestCara.SetActive(false);
        chestGambar.SetActive(false);
        chestVideo.SetActive(false);
        bounce.SetActive(false);
        bounceCara.SetActive(false);
        bounceGambar.SetActive(true);
        bounceVideo.SetActive(false);
        overhead.SetActive(false);
        overheadCara.SetActive(false);
        overheadGambar.SetActive(false);
        overheadVideo.SetActive(false);
    }

    public void toBounceVideo()
    {
        new ButtonSoundController().OnOffMusic();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        chest.SetActive(false);
        chestCara.SetActive(false);
        chestGambar.SetActive(false);
        chestVideo.SetActive(false);
        bounce.SetActive(false);
        bounceCara.SetActive(false);
        bounceGambar.SetActive(false);
        bounceVideo.SetActive(true);
        overhead.SetActive(false);
        overheadCara.SetActive(false);
        overheadGambar.SetActive(false);
        overheadVideo.SetActive(false);
    }

    public void toOverhead()
    {
        PlayerPrefs.SetInt("music", 1);
        GameObject bgm = GameObject.Find("BGM");
        bgm.GetComponent<AudioSource>().Play();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        chest.SetActive(false);
        chestCara.SetActive(false);
        chestGambar.SetActive(false);
        chestVideo.SetActive(false);
        bounce.SetActive(false);
        bounceCara.SetActive(false);
        bounceGambar.SetActive(false);
        bounceVideo.SetActive(false);
        overhead.SetActive(true);
        overheadCara.SetActive(false);
        overheadGambar.SetActive(false);
        overheadVideo.SetActive(false);
    }

    public void toOverheadCara()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        chest.SetActive(false);
        chestCara.SetActive(false);
        chestGambar.SetActive(false);
        chestVideo.SetActive(false);
        bounce.SetActive(false);
        bounceCara.SetActive(false);
        bounceGambar.SetActive(false);
        bounceVideo.SetActive(false);
        overhead.SetActive(false);
        overheadCara.SetActive(true);
        overheadGambar.SetActive(false);
        overheadVideo.SetActive(false);
    }

    public void toOverheadGambar()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        chest.SetActive(false);
        chestCara.SetActive(false);
        chestGambar.SetActive(false);
        chestVideo.SetActive(false);
        bounce.SetActive(false);
        bounceCara.SetActive(false);
        bounceGambar.SetActive(false);
        bounceVideo.SetActive(false);
        overhead.SetActive(false);
        overheadCara.SetActive(false);
        overheadGambar.SetActive(true);
        overheadVideo.SetActive(false);
    }

    public void toOverheadVideo()
    {
        new ButtonSoundController().OnOffMusic();
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        chest.SetActive(false);
        chestCara.SetActive(false);
        chestGambar.SetActive(false);
        chestVideo.SetActive(false);
        bounce.SetActive(false);
        bounceCara.SetActive(false);
        bounceGambar.SetActive(false);
        bounceVideo.SetActive(false);
        overhead.SetActive(false);
        overheadCara.SetActive(false);
        overheadGambar.SetActive(false);
        overheadVideo.SetActive(true);
    }

}
