using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeluarController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YaKeluar()
    {
        new ButtonEffectController().onClick();
        Application.Quit();
    }

    public void TidakKeluar()
    {
        new ButtonEffectController().onClick();
        this.gameObject.SetActive(false);
    }
}
