using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyingPlant : MonoBehaviour
{
    public GameObject buyWindow;
    // Start is called before the first frame update
    public void OpenWindow()
    {
        buyWindow.SetActive(true);
    }
    public void CloseWindow()
    {
        buyWindow.SetActive(false);
    }

    public void BuyPlant()
    {
    //animation for coins minus
    }

}
