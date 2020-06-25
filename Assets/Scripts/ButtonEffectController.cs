using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEffectController : MonoBehaviour
{
    private static ButtonEffectController instance = null;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {

    }
    // Music Global Start
    public static ButtonEffectController Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void onClick()
    {
        GameObject btnEfk = GameObject.Find("ButtonEffect");
        btnEfk.GetComponent<AudioSource>().Play();
    }

    // Music Global End
}
