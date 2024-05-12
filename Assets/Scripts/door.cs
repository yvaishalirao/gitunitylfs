using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.IK;

public class door : MonoBehaviour
{ public CoinCounter coun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public Vector2 playerPosition;
    public VectorValue playerStorage;
    [SerializeField] GameObject bomb;

    public void OnTriggerEnter2D(Collider2D other) {
        if(coun.cc>=0){
        if (other.CompareTag("Player")&& !other.isTrigger) {
            bomb.SetActive(true);
        }
        }
        else {Debug.Log("Need more coins"); }
    }

}
