using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    public float speed = 5;
    public float curr = 0;
    public float max = 200;
    public float min = 0;
    public Transform transform;
    public bool toRight = true;
    void Update()
    {
        Slide();
        if (curr < max && curr > min) toRight = true;
        else toRight = false;
    }

    void Slide()
    {
        if (toRight)
        {
            curr ++;
            transform.Translate((Vector2.right * Time.deltaTime));
        }
        else
        {
            curr --;
            transform.position = new Vector3(transform.position.x - speed,
                transform.position.y, transform.position.z);
        }
    }
}
