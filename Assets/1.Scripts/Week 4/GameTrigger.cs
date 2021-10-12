using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTrigger : MonoBehaviour
{
    public BoxCollider2D bc;
    public TMP_Text console;

    private void Awake()
    {
        bc.isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            console.text = "You Win";
        }

        Debug.Log("A collision has happened!!", gameObject);
    }
}
