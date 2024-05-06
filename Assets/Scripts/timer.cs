using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class boomtimer : MonoBehaviour
{
[SerializeField] TextMeshProUGUI timerText;
[SerializeField] float initTime;
public float remainingTime;
   void Start()
    {
        remainingTime=initTime;
    }
    void Update()
    {
        if(remainingTime>0)
        remainingTime-=Time.deltaTime;
        else if(remainingTime<=0)
        remainingTime=0;
        int minutes=Mathf.FloorToInt(remainingTime/60);
        int seconds=Mathf.FloorToInt(remainingTime%60);
        timerText.text=string.Format("{0:00}:{1:00}",minutes,seconds);
    }
    public float remTime {
        get { return remainingTime; }
    }
}
