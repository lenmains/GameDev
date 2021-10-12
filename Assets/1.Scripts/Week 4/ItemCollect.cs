using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    public BoxCollider2D bc;

    private void Awake()
    {
        bc.isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            ProgressCheck.progress++;
        }

        Debug.Log("A collision has happened!!", gameObject);
    }
}
