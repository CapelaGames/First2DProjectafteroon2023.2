using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject BulletPrefab;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(BulletPrefab, transform.position, Quaternion.identity);

        }
    }
}
