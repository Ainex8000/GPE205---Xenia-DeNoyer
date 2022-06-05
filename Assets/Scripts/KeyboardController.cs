using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : Controller
{
    public KeyCode moveForward;
    public KeyCode moveBackward;
    public KeyCode turnRight;
    public KeyCode turnLeft;
    public KeyCode shoot;

    // Start is called before the first frame update
    public override void Start()
    {
        // Add myself to the list of players
        GameManager.instance.players.Add(this);

        // Run the Start() function from the parent class
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        // Process our keyboard inputs
        MakeDecisions(); 
    }

    public void OnDestroy()
    {
        // Removes myself from the list of players
        GameManager.instance.players.Remove(this);
    }

    public override void MakeDecisions()
    {
        // Detects controller input
        if (Input.GetKey(moveForward))
        {
            pawn.MoveForward();
            Debug.Log("Forward");
        }
        if (Input.GetKey(moveBackward))
        {
            pawn.MoveBackward();
            Debug.Log("Backward");
        }

        if (Input.GetKey(turnRight))
        {
            pawn.TurnRight();
            Debug.Log("Right");
        }
        if (Input.GetKey(turnLeft))
        {
            pawn.TurnLeft();
            Debug.Log("Left");
        }

        if (Input.GetKey(shoot))
        {
            pawn.Shoot();
            Debug.Log("Shoot");
        }
    }
}
