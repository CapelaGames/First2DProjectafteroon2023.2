using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class EnemyManager : MonoBehaviour
{
    private Health _health;
    public int Damage = 20;

    private void Start()
    {
        _health = GetComponent<Health>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BulletMovement bullet = collision.GetComponent<BulletMovement>();
        if (bullet != null)
        {
            _health.Damage(bullet.Damage);
            Destroy(bullet.gameObject);
        }
    }
}
