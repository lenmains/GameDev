using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    
    private void Start()
    {
        Color color = spriteRenderer.color;
        color.a = 0f;
        spriteRenderer.color = color;
    }
    
    IEnumerator Fadein()
    {
        for(float f = 0.05f; f <= 1; f += 0.05f)
        {
            Color c = spriteRenderer.color;
            c.a = f;
            spriteRenderer.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void startFading()
    {
        StartCoroutine("FadeIn");
    }
}
