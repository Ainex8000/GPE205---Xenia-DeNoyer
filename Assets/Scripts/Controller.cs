using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    // Variable to hold our pawn
    public Pawn pawn;

    // Start is called before the first frame update
    public virtual void Start()
    {
        Debug.Log("Hello!");
    }

    // Update is called once per frame
    public virtual void Update()
    {
    }

    public virtual void MakeDecisions()
    {
    }
}
