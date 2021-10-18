using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class MyRayCastJump : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float jumpStrength = 5f;
    [SerializeField] private float movementSpeed = 5f;

    private float moveX;
    private bool isGrounded;
    private bool canJump;

    public float raycastDistance = 1f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void PlayerControls()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canJump = true;
        }

        moveX = Input.GetAxis("Horizontal");
        CheckGrounded();
    }

    void CheckGrounded()
    {

        RaycastHit2D groundRay = Physics2D.Raycast(transform.position, Vector2.down, raycastDistance);

        if (groundRay.collider != null && groundRay.collider.GetComponent<JumpObject>())
        {
            isGrounded = true;
        }

        else isGrounded = false;

    }

    void Jump()
    {
        if (!isGrounded)
        {
            return;
        }

        rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
        isGrounded = false;
    }

    public void OnDrawGizmos()
    {

        Color myColor;

        if(isGrounded) myColor = Color.green;
        else myColor = Color.red;
        Debug.DrawRay(transform.position, Vector2.down * raycastDistance, myColor);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveX * movementSpeed, rb.velocity.y);
        if (canJump)
        {
            canJump = false;
            Jump();
        }
    }

    void Update()
    {
        PlayerControls();
    }
}
