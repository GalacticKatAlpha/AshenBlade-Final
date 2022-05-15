using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 50;
    public int currentHealth = 50;
    public int Heal = 10;
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
            new WaitForSeconds(3);
            SceneManager.LoadScene("Death Screen");

        }

        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Dragon"))
        {
            TakeDamage(35);
        }
    }
}
