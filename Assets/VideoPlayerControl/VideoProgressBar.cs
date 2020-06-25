using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoProgressBar : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    [SerializeField]
    private VideoPlayer videoPlayer;

    private Image progress;

    public Text playPause;
    public GameObject layarHitam;


    public RawImage videoLayar;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void Awake()
    {
        progress = GetComponent<Image>();
    }

    private void Update()
    {
        if (videoPlayer.frameCount > 0)
            progress.fillAmount = (float)videoPlayer.frame / (float)videoPlayer.frameCount;

        if (progress.fillAmount > 0.99)
        {
            progress.fillAmount = 0;
            videoPlayer.Stop();
            layarHitam.SetActive(true);
            playPause.gameObject.SetActive(true);
            playPause.text = "Sentuh Untuk Mulai";

        }
    }

    public IEnumerator PlayVideo()
    {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while (!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        videoLayar.texture = videoPlayer.texture;
        videoPlayer.Play();
    }

    public void OnDrag(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    private void TrySkip(PointerEventData eventData)
    {
        Vector2 localPoint;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
            progress.rectTransform, eventData.position, null, out localPoint))
        {
            float pct = Mathf.InverseLerp(progress.rectTransform.rect.xMin, progress.rectTransform.rect.xMax, localPoint.x);
            SkipToPercent(pct);
        }
    }

    private void SkipToPercent(float pct)
    {
        var frame = videoPlayer.frameCount * pct;
        videoPlayer.frame = (long)frame;
    }

    public void PlayPause()
    {
        if (progress.fillAmount == 0)
        {
            StartCoroutine(PlayVideo());
            layarHitam.SetActive(false);
        }
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            playPause.text = "Sentuh Untuk Mulai";
            playPause.gameObject.SetActive(true);
        }
        else
        {
            videoPlayer.Play();
            playPause.gameObject.SetActive(false);
        }
    }
}