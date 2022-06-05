using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Variables needed
    public float damageDone;
    public Pawn owner;

    // Determines damage taken
    public void OnTriggerEnter(Collider other)
    {
        Health otherHealth = other.gameObject.GetComponent<Health>();
        if (otherHealth != null)
        {
            otherHealth.TakeDamage(damageDone, owner);
        }
        // Destroys the bullet
        Destroy(this.gameObject);
    }
}
