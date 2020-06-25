using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaranaPrasaranaController : MonoBehaviour
{
    public GameObject menu;
    public GameObject lapangan, bola, ring;
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


    public GameObject keluar;
    public void toKeluar()
    {
        new ButtonEffectController().onClick();
        keluar.SetActive(true);
    }

    public void toMateri()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("Materi");
    }

    public void toSarana()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(true);
        lapangan.SetActive(false);
        bola.SetActive(false);
        ring.SetActive(false);
    }

    public void toLapangan()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        lapangan.SetActive(true);
        bola.SetActive(false);
        ring.SetActive(false);
    }

    public void toBola()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        lapangan.SetActive(false);
        bola.SetActive(true);
        ring.SetActive(false);
    }
    public void toRing()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        lapangan.SetActive(false);
        bola.SetActive(false);
        ring.SetActive(true);
    }
}
