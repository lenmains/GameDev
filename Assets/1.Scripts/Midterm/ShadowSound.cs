using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowSound : MonoBehaviour
{
    public AudioSource audioSource;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            audioSource.Play();
        }
    }
}
