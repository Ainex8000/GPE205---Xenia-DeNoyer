using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPawn : Pawn
{
    // Variables needed
    public TankMover mover;
    public Shooter shooter;

    public GameObject bulletPrefab;
    public float damageDone;
    public float shootForce;
    public Transform shootPoint;

    private float countdown;
    public float timeBetweenShots;

    // Start is called before the first frame update
    public override void Start()
    {
        mover = GetComponent<TankMover>();
        shooter = GetComponent<Shooter>();

        // Set our countdown
        countdown = timeBetweenShots;
    }

    // Update is called once per frame
    public override void Update()
    {
        // Decrease our countdown by how much time has passed since the last update
        countdown = countdown - Time.deltaTime;
    }

    // Shoots projectile
    public override void Shoot()
    {
        // Check if countdown is <= 0
        if (countdown <= 0)
        {
            // If yes, then shoot
            shooter.Shoot(bulletPrefab, shootForce, damageDone, this, shootPoint);

            // Reset countdown
            countdown = timeBetweenShots;
        }
    }

    // Moves tank forward
    public override void MoveForward()
    {
        mover.MoveForward(moveSpeed);
        base.MoveForward();
    }

    // Moves tank backwards
    public override void MoveBackward()
    {
        mover.MoveForward(-moveSpeed);
        base.MoveBackward();
    }

    // Turns tank left
    public override void TurnLeft()
    {
        mover.Turn(-turnSpeed);
        base.TurnLeft();
    }

    // Turns tank right
    public override void TurnRight()
    {
        mover.Turn(turnSpeed);
        base.TurnRight();
    }
}
