using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover : Mover
{
    // Variables needed
    private Rigidbody rigidbodyComponent;

    // Start is called before the first frame update
    void Start()
    {
        // Load the components into the variables
        rigidbodyComponent = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }


    public override void MoveForward(float speed)
    {
        // Moves our tank
        rigidbodyComponent.MovePosition(transform.position + (transform.forward * (speed * Time.deltaTime)));
    }

    public override void Turn(float speed)
    {
        // Turn our tank
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
