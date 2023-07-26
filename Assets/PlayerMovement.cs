using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D _rigidbody;
    bool isJumpInput = false;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumpInput = true;
        }
    }

    void FixedUpdate()
    {
        //Getting input from the keyboard
        if(isJumpInput)
        {
            _rigidbody.AddForce(Vector2.up * 200f);
            isJumpInput = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(Vector2.right * 600f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(Vector2.left * 600f * Time.deltaTime);
        }
    }
}
