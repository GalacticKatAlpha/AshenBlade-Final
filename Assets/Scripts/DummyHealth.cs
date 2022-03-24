using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyHealth : MonoBehaviour
{
    public int maxHealth = 50;
    public int currentHealth;
    public bool alive = true;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        InvokeRepeating("DoDamage", 1, 5);
    }

    void DoDamage()
    {
        TakeDamage (10);
    }
    public void TakeDamage(int damage)
    {
        if (!alive)
        {
            return;
        }

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            currentHealth = maxHealth;
        }

        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
