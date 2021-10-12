using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RbSimpleMove : MonoBehaviour
{
    public Rigidbody2D rb;

    public float moveSpeed = 5.0f , jumpPower = 5.0f;

    [SerializeField]public bool isGrounded = false;
    [SerializeField]public bool canJump = false;

    private float moveX = 1.0f;


    void PlayerControls()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            canJump = true;
        }

        moveX = Input.GetAxis("Horizontal");
    }

    private void Jump()
    {

        if (!isGrounded) return;

        rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        isGrounded = false;
        Debug.Log("Jump!!");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        Debug.Log(collision.gameObject.name, collision.gameObject);
    }

    void Update()
    {
        PlayerControls();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);

        if (canJump)
        {
            canJump = false;    
            Jump();
        }

    }

}
