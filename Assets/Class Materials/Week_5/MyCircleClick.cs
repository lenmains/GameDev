using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCircleClick : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Color color1 = Color.red;
    public Color color2 = Color.green;

    private void Awake()    
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void SelectButton(int n)
    {

        if (n == 0) spriteRenderer.color = color1;
        else if (n == 1)
        {
            spriteRenderer.color = color2;
        }
    }

}
