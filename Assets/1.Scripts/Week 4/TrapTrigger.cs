using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    public BoxCollider2D bc;
    public GameObject player;

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
                Debug.Log("A trap has happened!!", gameObject);
            }
        }
    }
}
