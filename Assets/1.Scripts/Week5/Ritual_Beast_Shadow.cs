using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ritual_Beast_Shadow : MonoBehaviour
{
    public static bool hasShadow = false;
    public BoxCollider2D bc;
    public AudioSource audioSource;
    public GameObject Trigger;

    void Awake()
    {
        bc.isTrigger = true;
    }

    void Update()
    {

    }

    void OnTriggerEnter2D()
    {
        hasShadow = true;
        audioSource.Play();
        this.gameObject.SetActive(false);
        Trigger.SetActive(false);
    }
}
