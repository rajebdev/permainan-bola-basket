using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject petunjuk, quiz, menu;
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
        menu.SetActive(true);
        petunjuk.SetActive(false);
        quiz.SetActive(false);
    }

    public void toPetunjuk()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        petunjuk.SetActive(true);
        quiz.SetActive(false);
    }

    public void toMateri()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("Materi");
    }

    public void toQuiz()
    {
        new ButtonEffectController().onClick();
        menu.SetActive(false);
        petunjuk.SetActive(false);
        quiz.SetActive(true);
    }


    public GameObject keluar;

    public void toKeluar()
    {
        new ButtonEffectController().onClick();
        keluar.SetActive(true);
    }

    public void toStartQuiz()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("Quiz");
    }

    public void toIntroDetail()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("Intro");
        PlayerPrefs.SetInt("toIntroDetail", 1);
    }
}
