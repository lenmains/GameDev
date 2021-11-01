using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoundRitualBeast_Shadow : MonoBehaviour
{
    public BoxCollider2D bc;
    [SerializeField] private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            audioSource.Play();
        }
    }
}
