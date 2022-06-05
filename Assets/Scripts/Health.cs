using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Variables needed
    public float maxHealth;
    public float currentHealth;

    public void Start()
    {
        // Sets health to max health upon start
        currentHealth = maxHealth;
    }

    public void TakeDamage(float amount, Pawn owner)
    {
        // Subtracts damage from health
        currentHealth = currentHealth - amount;

        // Determines what to do once player's health reaches 0
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Destroys the game object once it is dead
    public void Die()
    {
        Destroy(this.gameObject);
        Debug.Log("Dead");
    }

}
