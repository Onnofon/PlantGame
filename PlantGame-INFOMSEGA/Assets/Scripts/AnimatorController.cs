using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public GameObject wateringCan;
    public Transform target;

    public void trigerWateringCanAnimation()
    {
        //Destroy this gameobject, 5 seconds after its created.
        Destroy(Instantiate(wateringCan, target), 2f);
    }
}
