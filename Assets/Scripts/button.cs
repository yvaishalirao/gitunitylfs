using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject led1;
    public GameObject bomb;
    public boomtimer timer;
    private float Remaining;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       Remaining = Mathf.FloorToInt(timer.remTime)%60;
    
    }
    void OnMouseDown()
    {
        if(Remaining%10==7)
        led1.GetComponent<SpriteRenderer>().color = Color.green;
        else
        bomb.SetActive(false);
    }
}

