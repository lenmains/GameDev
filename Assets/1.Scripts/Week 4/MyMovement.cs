using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMovement : MonoBehaviour
{

    public float speed = 2.5f;
    public Animator animator;
    public bool isMoving = false;
    public float activitionTime = 0;
   

    void MoveObject()
    {
        Vector3 characterScale = transform.localScale;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate((Vector2.left * Time.deltaTime) * speed);
            characterScale.x = -1;

            isMoving = true;
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate((Vector2.right * Time.deltaTime) * speed);
            characterScale.x = 1;

            isMoving = true;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate((Vector2.up * Time.deltaTime) * speed);

            isMoving = true;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate((Vector2.down * Time.deltaTime) * speed);

            isMoving = true;
        }

        if(isMoving) animator.SetFloat("Speed", 1);
        else
        {
            animator.SetFloat("Speed", -1);
        }

        transform.localScale = characterScale;

    }

    void Update()
    {
        isMoving = false;
        MoveObject();
    }
}