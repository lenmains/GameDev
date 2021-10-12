using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trap : MonoBehaviour
{
    public BoxCollider2D bc;
    public GameObject player;
    public TMP_Text console;

    private void Awake()
    {
        bc.isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.transform.position = new Vector3(-32, 2, 0);
            console.text = "You have been killed by a trap.";

        }
    }
}
