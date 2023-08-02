using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject BulletTemplate; //Prefab

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = 
                Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = transform.position.z;

            //Explain this next week
            Vector3 directionToMouse = mousePosition - transform.position;
            float angle = Mathf.Atan2(directionToMouse.y, directionToMouse.x) * Mathf.Rad2Deg;  

            Quaternion test = Quaternion.Euler(0,0, angle);
            Instantiate(BulletTemplate, transform.position, test);
        }
    }
}
