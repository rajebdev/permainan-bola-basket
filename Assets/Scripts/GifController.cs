using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GifController : MonoBehaviour
{

    public string nameFile;
    public int frameCount;
    private Sprite[] spritesGif;

    // Start is called before the first frame update
    void Start()
    {
        spritesGif = new Sprite[frameCount];
        for (int i=0; i < frameCount; i++)
        {
            string fullPath = nameFile + " (" + (i + 1).ToString() + ")";
            spritesGif[i] = Resources.Load<Sprite>(fullPath);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        int index = (int)((Time.time * 10) % frameCount);
        this.gameObject.GetComponent<Image>().sprite = spritesGif[index];
    }
}
