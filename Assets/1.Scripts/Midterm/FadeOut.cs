using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    float timer;

    IEnumerator Fadeout()
    {
        for(float f = 1f; f >= -0.05f; f -= 0.05f)
        {
            Color c = spriteRenderer.color;
            c.a = f;
            spriteRenderer.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.G))
        {
            if (timer > 2)
            {
               StartCoroutine("Fadeout");
                timer = 0;
                Debug.Log("FadeOut");
            }
        }
    }
}
