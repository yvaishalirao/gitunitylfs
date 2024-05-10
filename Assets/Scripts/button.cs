using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using UnityEngine;
using TMPro;
using UnityEngine.Video;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public GameObject[] led;
    public GameObject bomb;
    public boomtimer timer;
    [SerializeField] GameObject defutext;
    [SerializeField] GameObject bmb;
    [SerializeField] GameObject timtext;
    [SerializeField] Scene GO;
    [SerializeField] GameObject canv;
   
    private SceneSwitcher sceneSwitcher;

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
        if(Remaining<0 && ((led[0].GetComponent<SpriteRenderer>().color == Color.red) || (led[1].GetComponent<SpriteRenderer>().color == Color.red) ||(led[2].GetComponent<SpriteRenderer>().color == Color.red) ||(led[3].GetComponent<SpriteRenderer>().color == Color.red)))
        {
            expl();
        }
        if (Input.GetMouseButtonDown(0))
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
        expl();

    }
    
    }
    }    
    public void expl()
    {   canv.SetActive(true);
        }
}


