using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Functions
//Collisions
//Shooting


public class EnemyMovement : MonoBehaviour
{
    public float speed = 10;
    public bool isMovingRight = true;

    void Start()
    {

    }
    void Update()
    {
        if (isMovingRight)
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }

        if(transform.position.x >= 10)
        {
            isMovingRight = false;
        }
        if(transform.position.x <= -10)
        {
            isMovingRight = true;
        }
    }

    //  if ( x == y)
    //  {
    //   if true, run code in here
    //  }

    //Comparison Operators
    // x == y  -> is x equal to y
    // x != y  -> is x not equal to y
    // x > y   -> is x greater than y
    // x < y   -> is x less than y
    // x <= y  -> is x less than or equal to y
    // x >= y  -> is x greater than or equal to y
}
