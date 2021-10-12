using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrapTrigger : MonoBehaviour
{
    public BoxCollider2D bc;
    public GameObject player;
    public TMP_Text console;

    private void Awake()
    {
        bc.isTrigger = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                player.transform.position = new Vector3(-32, 2, 0);
                console.text = "You have been Killed by a trap.";
            }
        }
    }
}
