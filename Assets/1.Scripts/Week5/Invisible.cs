using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color color;
    public float activationTime = 0;
    public bool invisible = false;
    public Animator animator;

    void Awake()
    {
        color = spriteRenderer.color;
    }

    private void Summon()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetBool("IsSummoning", true);
            activationTime = 0;
            invisible = true;
        }

        if (invisible && activationTime >= 1)
        {
            color.a = 0.2f;
            spriteRenderer.color = this.color;
            animator.SetBool("IsSummoning", false);
        }

        if (invisible && activationTime >= 4)
        {
            invisible = false;
            color.a = 1;
            spriteRenderer.color = this.color;
        }
    }

    void Update()
    {
        activationTime += Time.deltaTime;
        if (Ritual_Beast_Shadow.hasShadow)
        {
            Summon();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Invisible")
        {
            invisible = true;
            activationTime = 0;
            color.a = 0.2f;
            spriteRenderer.color = this.color;
        }
    }
}
