using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    void Update()
    {

        //Getting input from the keyboard
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D playerRB = GetComponent<Rigidbody2D>();

            playerRB.AddForce(Vector2.up * 200f);
        }

        // Debug.Log(jumpInput);
    }
}
