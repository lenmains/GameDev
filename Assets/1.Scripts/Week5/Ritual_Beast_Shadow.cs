using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ritual_Beast_Shadow : MonoBehaviour
{
    public static bool hasShadow = false;
    public BoxCollider2D bc;

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
        this.gameObject.SetActive(false);
    }
}
