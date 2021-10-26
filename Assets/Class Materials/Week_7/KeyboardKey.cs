using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class KeyboardKey : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip audioclip;

    public KeyCode keyboardButton;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void KeyboardInput()
    {
        if (Input.GetKeyDown((keyboardButton)))
        {
            PlayKey();
        }
    }

    void PlayKey()
    {
        audioSource.PlayOneShot(audioclip);
    }

    void Update()
    {
        KeyboardInput();
    }
}
