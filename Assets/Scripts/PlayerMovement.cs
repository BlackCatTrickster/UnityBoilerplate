using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = rb.velocity;
        if (Input.GetKey(KeyCode.D))
            rb.velocity = new Vector3(5, vel.y, vel.z);
        if (Input.GetKey(KeyCode.A)) 
            rb.velocity = new Vector3(-5, vel.y, vel.z);
        if (Input.GetKey(KeyCode.Space)) 
            rb.velocity = new Vector3(vel.x, 5, vel.z);
    }
}
