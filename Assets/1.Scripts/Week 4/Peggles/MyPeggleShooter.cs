using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPeggleShooter : MonoBehaviour
{
    public Rigidbody2D ball;
    Vector3 ballStartPosition;

    private void Start()
    {
        ballStartPosition = ball.transform.localPosition;
    }

    public void ResetBall()
    {
        ball.angularVelocity = 0;
        ball.simulated = false;
        ball.velocity = new Vector2(0,0);

        ball.transform.SetParent(transform, true);
        ball.transform.localPosition = ballStartPosition;
        ball.transform.localRotation = Quaternion.Euler(Vector3.zero);

    }
}
