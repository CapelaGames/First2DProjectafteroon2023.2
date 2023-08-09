using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class EnemyManager : MonoBehaviour
{
    private Health _health;

    public int Damage = 20;
 
    void Start()
    {
        _health = GetComponent<Health>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Bullet bullet = collision.GetComponent<Bullet>();
        if (bullet != null)
        {
            _health.Damage(bullet.Damage);
            Destroy(bullet.gameObject);

        }
    }
}
