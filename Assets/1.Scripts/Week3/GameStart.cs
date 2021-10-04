using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private bool hasStarted = false;
    public float power = 50.0f;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        PressSpaceToStart();
    }
    
    void PressSpaceToStart()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !hasStarted)
        {
            hasStarted = true;
            rb.AddForce(Vector2.right * power);
        }
    }
}
