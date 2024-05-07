using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using UnityEngine;
using TMPro;
using UnityEngine.Video;
using Unity.VisualScripting;

public class button : MonoBehaviour
{
    public GameObject[] led;
    public GameObject bomb;
    public boomtimer timer;
    [SerializeField] GameObject defutext;
    [SerializeField] GameObject bmb;
    [SerializeField] GameObject timtext;
    [SerializeField] GameObject gotext;

    [SerializeField] GameObject scr;
    public VideoPlayer vp;


    private float Remaining;
    // Start is called before the first frame update
    void Start()
    {
        led[0].GetComponent<SpriteRenderer>().color = Color.red;
        led[1].GetComponent<SpriteRenderer>().color = Color.red;
        led[2].GetComponent<SpriteRenderer>().color = Color.red;
        led[3].GetComponent<SpriteRenderer>().color = Color.red;

    }

    // Update is called once per frame
    void Update()
    {
       Remaining = Mathf.FloorToInt(timer.remTime)%60;
        if((led[0].GetComponent<SpriteRenderer>().color == Color.green) && (led[1].GetComponent<SpriteRenderer>().color == Color.green) &&(led[2].GetComponent<SpriteRenderer>().color == Color.green) &&(led[3].GetComponent<SpriteRenderer>().color == Color.green))
        {
            timtext.SetActive(false);
            defutext.SetActive(true);
        }
    
    }
    void OnMouseDown()
    {  
        if(Remaining%10==7)
        led[0].GetComponent<SpriteRenderer>().color = Color.green;
        else if(Remaining%10==5)
        led[1].GetComponent<SpriteRenderer>().color = Color.green;
        else if(Remaining%10==2)
        led[2].GetComponent<SpriteRenderer>().color = Color.green;
        else if(Remaining%10==0)
        led[3].GetComponent<SpriteRenderer>().color = Color.green;
        else 
        {
        bmb.GetComponent<SpriteRenderer>().sprite=null;
        timtext.SetActive(false);
        gotext.SetActive(true);
        scr.SetActive(true);
        vp.Play();
        }

    }
}

