using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;
using System;

public class YouWin : MonoBehaviour
{
    private BoxCollider2D bc;
    public TMP_Text myText;

    private void Awake()
    {
        bc = GetComponent<BoxCollider2D>();
        bc.isTrigger = true;
        myText.gameObject.SetActive(false);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            myText.gameObject.SetActive(true);
        }


        Debug.Log("A collision has happened!!", gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("A collision has happened again!!!");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

    }
}