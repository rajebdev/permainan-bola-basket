using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MateriController : MonoBehaviour
{
    public GameObject menu, sejarah, gerakDasar;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("GerakDasar") == 1)
        {
            toGerakDasar();
            PlayerPrefs.DeleteKey("GerakDasar");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toMateri()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(true);
        gerakDasar.SetActive(false);
        sejarah.SetActive(false);
    }

    public void toSejarah()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        gerakDasar.SetActive(false);
        sejarah.SetActive(true);
    }

    public void toGerakDasar()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        gerakDasar.SetActive(true);
        sejarah.SetActive(false);
    }

    public void toGerakPokok()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("GerakPokok");
    }

    public void toGerakTambahan()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("GerakTambahan");
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

    public void toSaranaPrasarana()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("SaranaPrasarana");
    }

    public void toPeraturan()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("Peraturan");
    }
}
