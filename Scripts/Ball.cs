using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle p1;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;
    bool hasStarted = false;
    Vector2 p2b;

    void Start()
    {
        p2b = transform.position - p1.transform.position;
    }

    
    void Update()
    {
        if(!hasStarted)
        {
            LockB2P();
            LaunchBall();
        }
    }

    private void LockB2P()
    {
        Vector2 paddlePos = new Vector2(p1.transform.position.x, p1.transform.position.y);
        transform.position = paddlePos + p2b;
    }

    private void LaunchBall()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
            hasStarted = true;
        }
    }
}
