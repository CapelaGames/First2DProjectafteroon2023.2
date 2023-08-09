using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//PascalCase - Class names, Function names, public variables
//camelCase - Variables
//private variables use _


public class Health : MonoBehaviour
{
    public TMP_Text HealthText;

    private int _health = 100;
    private int _maxHealth = 100;

    public void DisplayHealth()
    {
        if (HealthText != null)
        {
            HealthText.text = "Health: " + _health;
        }
    }

    public void Damage(int damage)
    {
        _health -= damage;

        if(_health <= 0)
        {
            //_health = 0;
            Destroy(gameObject);
        }
        DisplayHealth();
    }

    public void Heal(int heal)
    {
        _health = Mathf.Min(_maxHealth, _health + heal);
        DisplayHealth();
    }
}
