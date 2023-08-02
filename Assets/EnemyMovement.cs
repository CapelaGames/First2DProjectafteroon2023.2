using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Functions
//Collisions
//Shooting
public class EnemyMovement : MonoBehaviour
{
    public float speed;
    bool isMovingRight = true;

    void Update()
    {
        if (isMovingRight)
        {
            transform.position += new Vector3(speed, 0) * Time.deltaTime;
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }

        if(transform.position.x >= 10)
        {
            isMovingRight = false;
        }
        if (transform.position.x <= -10)
        {
            isMovingRight = true;
        }
    }
}
// comparison operators
// if ( x == y ) // is x equal to y
// if ( x != y ) //is x not equal to y
// if ( x > y ) // is x greater than y
// if ( x < y ) // is x less than y
// is ( x >= y) // is x  greater than or equal to y
// is ( x <= y) // is x  less than or equal to y




/*
int wholeNumber = 30;
//health, ammo count, stats, points

float decimalNumber = 29.7f;
//position, rotation, scale, time

string words = "hello my name is";

bool example = true;//false
*/