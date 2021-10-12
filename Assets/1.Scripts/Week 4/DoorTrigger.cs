using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public BoxCollider2D bc;
    public GameObject Door1;

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
                Door1.SetActive(false);
                Debug.Log("A Interaction has happened!!", gameObject);
            }
        }

        Debug.Log("A collision has happened!!", gameObject);
    }
}
