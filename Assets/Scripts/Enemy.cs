using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int enemyHealth = 100;
    [SerializeField] GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        enemyHealth = enemyHealth - damage;

        if (enemyHealth <= 0)
        {
            TriggerDeathVFX();
            Die();
        }
    }

    private void TriggerDeathVFX()
    {
        if (!deathEffect)
        {
            return;
        }
        else
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
