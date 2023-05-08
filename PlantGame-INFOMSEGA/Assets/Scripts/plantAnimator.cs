using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantAnimator : MonoBehaviour
{
    public Animator plantAnimatorController;

    public void triggerGrowAnimation()
    {
        plantAnimatorController.SetTrigger("grow");
    }

    public void plantWantsWaterAnimation()
    {
        plantAnimatorController.SetBool("wantWater", true);
    }
    public void plantHasWaterAnimation()
    {
        plantAnimatorController.SetBool("wantWater", false);
    }
}
