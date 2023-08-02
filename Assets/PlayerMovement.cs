using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;
    bool isJumpInput = false;
    bool isGrounded = false;

    private void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isJumpInput = true;
        }
    }
    private void FixedUpdate()
    {
        if (isJumpInput && isGrounded)
        {
            playerRB.AddForce(Vector2.up * 200f);
        }
        isJumpInput = false;

        if (Input.GetKey(KeyCode.D))
        {
            playerRB.AddForce(Vector2.right * 1000f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRB.AddForce(Vector2.right * -1000f * Time.deltaTime);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}


