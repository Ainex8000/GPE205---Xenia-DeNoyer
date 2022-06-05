using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;

    // Start is called before the first frame update
    public virtual void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update() 
    { 
    }

    public virtual void Shoot()
    {
    }

    public virtual void MoveForward()
    {
    }

    public virtual void MoveBackward()
    {
    }

    public virtual void TurnLeft()
    {
    }

    public virtual void TurnRight()
    {
    }
}
