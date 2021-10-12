using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProgressCheck : MonoBehaviour
{
    public static int progress;
    private TMP_Text myText;

    private void Awake()
    {
        myText = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        myText.text = progress + " / 5 Collected";
    }
}
