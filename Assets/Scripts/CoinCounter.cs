using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class CoinCounter : MonoBehaviour
{
    
    public static CoinCounter instance;
    public TMP_Text coinText;
    public int currentCoins=0;

    void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        coinText.text="COCOS: "+currentCoins.ToString();
    }

    // Update is called once per frame
    public void IncreaseCoin(int v){
        currentCoins+=v;
        coinText.text="COCOS: " +currentCoins.ToString();
    }
    public int cc{
        get{return currentCoins;}
    }
    }

