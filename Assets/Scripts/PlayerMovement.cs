using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;
    private Rigidbody rb;
    public float jumpForce = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Player movement
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -playerSpeed);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * playerSpeed);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * -playerSpeed);
        }

        // Player jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
}
