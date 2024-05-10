using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class boomtimer : MonoBehaviour
{
[SerializeField] TextMeshProUGUI timerText;
[SerializeField] float initTime;
[SerializeField] GameObject goscreen;

private float remainingTime;
private float cal;
   void Start()
    {
        remainingTime=initTime;
        cal = 600/remainingTime;
    }
    void Update()
    {
        if(remainingTime>0)
        {
        remainingTime-=Time.deltaTime;
        }
        else if(remainingTime<=0){
        remainingTime=0;
        goscreen.SetActive(true);
        }
        int minutes=Mathf.FloorToInt(remainingTime/60);
        int seconds=Mathf.FloorToInt(remainingTime%60);
        timerText.text=string.Format("{0:00}:{1:00}",minutes,seconds);
    }
    public float remTime {
        get { return remainingTime; }
    }
}
