using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonHealth : MonoBehaviour
{
    public int maxHealth = 50;
    public int currentHealth;
    public bool alive = true;
    public Animator anim;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
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

            alive = false;
            anim.SetTrigger("Death");
            gameObject.tag = "Untagged";
            GetComponent<AudioSource>().enabled = false;
            GetComponent<Patroller>().enabled = false;
            GetComponent<DragonAttacks>().enabled = false;
            GetComponent<CapsuleCollider>().enabled = false;
        }

        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            TakeDamage(20);
        }
    }
}
