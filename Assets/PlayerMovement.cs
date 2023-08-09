using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D _playerRB;
    SpriteRenderer _spriteRenderer;
    bool _isJumpInput = false;
    bool _isGrounded = false;

    private void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _isJumpInput = true;
        }
    }
    private void FixedUpdate()
    {
        if (_isJumpInput && _isGrounded)
        {
            _playerRB.AddForce(Vector2.up * 400f);
        }
        _isJumpInput = false;

        if (Input.GetKey(KeyCode.D))
        {
            _playerRB.AddForce(Vector2.right * 1000f * Time.deltaTime);
            _spriteRenderer.flipX = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _playerRB.AddForce(Vector2.right * -1000f * Time.deltaTime);
            _spriteRenderer.flipX = false;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            _isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            _isGrounded = false;
        }
    }
}


