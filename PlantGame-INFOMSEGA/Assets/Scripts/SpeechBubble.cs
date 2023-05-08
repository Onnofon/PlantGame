using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeechBubble : MonoBehaviour
{
    public TMPro.TextMeshProUGUI speechBubbleText;
    public SpriteRenderer speechBubbleImg;
    public Image buttonImg;
    public TMPro.TextMeshProUGUI buttonText;
    public Button button;
    public void FadeSpeechIn()
    {
        StartCoroutine(FadeTextToFullAlpha(1f,speechBubbleText,speechBubbleImg, buttonImg, buttonText));
        button.interactable = true;
    }
    
    public void FadeSpeechOut()
    {
        StartCoroutine(FadeTextToZeroAlpha(1f, speechBubbleText, speechBubbleImg, buttonImg, buttonText));
        button.interactable = false;
    }


    public IEnumerator FadeTextToFullAlpha(float t, TMPro.TextMeshProUGUI i, SpriteRenderer a, Image b,TMPro.TextMeshProUGUI f)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, (i.color.a + (Time.deltaTime / t)));
            a.color = new Color(a.color.r, a.color.g, a.color.b, (i.color.a - (Time.deltaTime / t)));
            b.color = new Color(b.color.r, b.color.g, b.color.b, (i.color.a - (Time.deltaTime / t)));
            f.color = new Color(f.color.r, f.color.g, f.color.b, (i.color.a - (Time.deltaTime / t)));
            yield return null;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, TMPro.TextMeshProUGUI i, SpriteRenderer a, Image b, TMPro.TextMeshProUGUI f)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, (i.color.a - (Time.deltaTime / t)));
            a.color = new Color(a.color.r, a.color.g, a.color.b, (i.color.a - (Time.deltaTime / t)));
            b.color = new Color(b.color.r, b.color.g, b.color.b, (i.color.a - (Time.deltaTime / t)));
            f.color = new Color(f.color.r, f.color.g, f.color.b, (i.color.a - (Time.deltaTime / t)));
            yield return null;
        }
    }
}
