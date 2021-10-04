using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CameraChange2 : MonoBehaviour
{
    private BoxCollider2D bc;
    public GameObject Camera1;
    public GameObject Camera2;

    private void Awake()
    {
        bc = GetComponent<BoxCollider2D>();
        bc.isTrigger = true;

        Camera1.SetActive(true);
        Camera2.SetActive(false);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            Camera2.SetActive((true));
            Camera1.SetActive(false);
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