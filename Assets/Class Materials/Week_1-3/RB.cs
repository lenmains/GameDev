using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RB : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool moveLeft;
    private bool moveRight;
    private float power = 5.0f;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void CheckInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveLeft = true;
        }
        else
        {
            moveLeft = false;
        }

        moveRight = Input.GetKey(KeyCode.RightArrow);
    }

    private void Update()
    {
        
        CheckInput();

    }

    private void FixedUpdate()
    {

        if (moveLeft)
            rb.AddForce(Vector2.left * power);

        if (moveRight)
            rb.AddForce(Vector2.right * power);
    } 
}
