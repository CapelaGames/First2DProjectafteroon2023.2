using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 10f;
   
    void Update()
    {
        transform.position += transform.right * Speed * Time.deltaTime;
    }
}
