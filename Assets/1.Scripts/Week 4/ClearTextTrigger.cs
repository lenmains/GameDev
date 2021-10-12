using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClearTextTrigger : MonoBehaviour
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
            console.text = "";
        }
    }
}
