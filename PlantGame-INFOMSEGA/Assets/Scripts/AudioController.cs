using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public static AudioController Instance;
    public int progress;
    public Animator plantAnim;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        
    }

    public AudioSource backGround;
    public AudioSource buttonClicked;
    public AudioSource wateringEffect;

    public void clickButton()
    {
        buttonClicked.Play();
    }

    public void waterEffect()
    {
        wateringEffect.Play();
    }


    public void increaseProgress()
    {
        plantAnim = GameObject.FindGameObjectWithTag("Plant").GetComponent<Animator>();
        progress += 25;
        if (progress >= 100)
        {
            growPlant();
        }
    }

    void growPlant()
    {
        plantAnim.SetTrigger("grow");
        progress = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) { plantAnim = GameObject.FindGameObjectWithTag("Plant").GetComponent<Animator>(); plantAnim.SetTrigger("degrow"); }
    }
}
