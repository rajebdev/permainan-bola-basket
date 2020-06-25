using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PeraturanController : MonoBehaviour
{
    public GameObject menu, wasit, waktu, permainan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toPeraturan()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(true);
        wasit.SetActive(false);
        waktu.SetActive(false);
        permainan.SetActive(false);
    }

    public void toWasit()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        wasit.SetActive(true);
        waktu.SetActive(false);
        permainan.SetActive(false);
    }

    public void toWaktu()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        wasit.SetActive(false);
        waktu.SetActive(true);
        permainan.SetActive(false);
    }

    public void toPermainan()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        wasit.SetActive(false);
        waktu.SetActive(false);
        permainan.SetActive(true);
    }

    public void toHome()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("Menu");
    }

    public void toMateri()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("Materi");
    }

    public GameObject keluar;

    public void toKeluar()
    {
        new ButtonEffectController().onClick();
        keluar.SetActive(true);
    }
}
