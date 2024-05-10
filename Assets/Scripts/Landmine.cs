using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using TMPro;
using UnityEngine.Video;
using Unity.VisualScripting;
public class Landmine : MonoBehaviour
{
[SerializeField] GameObject canv;
    public VideoPlayer vp;
    public void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")&& !other.isTrigger) {
        StartCoroutine(waitt());
        canv.SetActive(true);
        }
    IEnumerator waitt()
    {
        yield return new WaitForSeconds(1);
    }
    }
}
