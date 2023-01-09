using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot,minutesPivot,secondsPivot;

    // Start is called before the first frame update
    void Start()
    {
        DateTime currentTime = DateTime.Now;
        hoursPivot.localRotation = Quaternion.Euler(0,0,-currentTime.Hour*30);
        minutesPivot.localRotation = Quaternion.Euler(0,0,-currentTime.Minute*6);
        secondsPivot.localRotation=Quaternion.Euler(0,0,-currentTime.Second*6);
    }

    // Update is called once per frame
    void Update()
    {
        DateTime currentTime = DateTime.Now;
        hoursPivot.localRotation = Quaternion.Euler(0,0,-currentTime.Hour*30);
        minutesPivot.localRotation = Quaternion.Euler(0,0,-currentTime.Minute*6);
        secondsPivot.localRotation=Quaternion.Euler(0,0,-currentTime.Second*6);
    }
}
