using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Slide : MonoBehaviour
{
    private BoxCollider2D bc;
    [SerializeField] private Rigidbody2D rb;
    public float power = 5f;

    private void Awake()
    {
        bc = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            rb.AddForce(Vector2.right * power);
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