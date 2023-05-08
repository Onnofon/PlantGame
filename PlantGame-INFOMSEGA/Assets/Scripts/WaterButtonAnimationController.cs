using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterButtonAnimationController : MonoBehaviour
{
    public Animator btnAnimatorComponent;
    public beeAnimator bee;

    public void triggerButtonAnimation()
    {
        btnAnimatorComponent.SetTrigger("buttonIsClicked");
        StartCoroutine(AnimationTrigger());
    }

    private IEnumerator AnimationTrigger()
    {
        yield return new WaitForSeconds(2.5f);
        bee.triggerBuzzAnimation();
        Debug.Log("Buzz");
    }
}
