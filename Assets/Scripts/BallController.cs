using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveBallHorizontal = Input.GetAxisRaw("Horizontal");
        float moveBallVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveBallHorizontal, 0.0f, moveBallVertical);

        rb.AddForce(movement * speed);

    }
}
