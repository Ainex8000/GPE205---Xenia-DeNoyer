using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooter : Shooter
{
    public override void Shoot(GameObject bulletPrefab, float shootForce, float damageDone, Pawn shooter, Transform shootPoint)
    {
        // Create the bullet
        GameObject theBullet = Instantiate(bulletPrefab, shootPoint.position, transform.rotation);

        // Give it the data it needs
        Projectile projectile = theBullet.GetComponent<Projectile>();

        if (projectile != null)
        {
            projectile.damageDone = damageDone;
            projectile.owner = shooter;
        }

        // Push it
        Rigidbody bulletRb = theBullet.GetComponent<Rigidbody>();
        if (bulletRb != null)
        {
            bulletRb.AddForce(transform.forward * shootForce);
        }

        // Destroys bullet after five seconds
        Destroy(theBullet, 5);
    }
}
