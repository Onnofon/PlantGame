using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beeAnimator : MonoBehaviour
{
    public Animator beeAnimatorComponent;
    public SpeechBubble speechBubble;

    public void triggerBuzzAnimation()
    {
        beeAnimatorComponent.SetTrigger("Buzz");
        speechBubble.FadeSpeechIn();
    }
}
