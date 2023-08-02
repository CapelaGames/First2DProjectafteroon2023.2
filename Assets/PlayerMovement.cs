using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private bool _isJumpInput = false;
    private bool _isGrounded = false;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isJumpInput = true;
        }
    }

    void FixedUpdate()
    {
        //Getting input from the keyboard
        if (_isJumpInput && _isGrounded)                                                                                                               
        {
            _rigidbody.AddForce(Vector2.up * 200f);
        }
        _isJumpInput = false;

        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(Vector2.right * 600f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(Vector2.left * 600f * Time.deltaTime);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        _isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _isGrounded = false;
    }
}
