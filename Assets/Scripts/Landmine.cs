using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Landmine : MonoBehaviour
{
[SerializeField] GameObject canv;
    public void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")&& !other.isTrigger) {
            canv.SetActive(true);
        }
    
    }
}
