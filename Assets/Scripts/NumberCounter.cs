using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberCounter : MonoBehaviour
{
    public static NumberCounter instance;
    public TMP_Text numText;
    public String currentNum="";

    void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        numText.text="HINT: "+currentNum;
    }

    // Update is called once per frame
    public void IncreaseNum(String v){
        currentNum+=v;
        numText.text="HINT: " +currentNum;
    }
    
}
