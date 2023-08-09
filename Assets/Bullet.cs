using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 10f;
    public int Damage = 50;
   
    void Update()
    {
        transform.position += transform.right * Speed * Time.deltaTime;
    }
}
