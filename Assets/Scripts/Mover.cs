using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mover : MonoBehaviour
{
    // Movement speed
    public abstract void MoveForward(float speed);

    // Turn speed
    public abstract void Turn(float speed);
}
