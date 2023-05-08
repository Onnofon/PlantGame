using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVariablesController : MonoBehaviour
{
    AudioController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = AudioController.Instance;
    }

    public void playButtonSound()
    {
        instance.clickButton();
    }

    public void playWaterCanEffect()
    {
        instance.waterEffect();
    }

    public void growPlant()
    {
        instance.increaseProgress();
    }
}
