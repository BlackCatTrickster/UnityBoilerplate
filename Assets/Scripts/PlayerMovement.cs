using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpCooldown = 1.0f; // Time in seconds between jumps
    private Rigidbody rb;
    private float lastJumpTime = -999f; // Time when last jump occurred

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 vel = rb.velocity;

        if (Input.GetKey(KeyCode.D))
            rb.velocity = new Vector3(5, vel.y, vel.z);

        if (Input.GetKey(KeyCode.A))
            rb.velocity = new Vector3(-5, vel.y, vel.z);

        // Check if enough time has passed since last jump
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= lastJumpTime + jumpCooldown)
        {
            rb.velocity = new Vector3(vel.x, 10, vel.z);
            lastJumpTime = Time.time; // Record when we jumped
        }
    }
}
