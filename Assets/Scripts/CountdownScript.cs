using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CountdownScript : MonoBehaviour
{
    public GameObject countdownTimer;
    public bool boolin = false;
    public RubbishBagManager rubbishBags;

    //void Update()
    //{

        //BeginCountdown();
    //}

    public void BeginCountdown()
    {
        countdownTimer.SetActive(true);
        rubbishBags.SpawnIn();
    }
}
