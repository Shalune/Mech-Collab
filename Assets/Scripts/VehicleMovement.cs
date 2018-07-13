using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovement : MonoBehaviour {

    public float turnAccel;
    public float forwardAccel;
    public float reverseAccel;
    public float turnMax;
    public float forwardMax;
    public float reverseMax;
    public float runDecel;

    protected float runVelocity = 0f;
    protected float turnForce = 0f;

    private CameraFollow cameraFollow;

    public virtual void ApplyMovement(Rigidbody2D rigidBody, Vector2 input)
    {
        turnForce = input.x;
        runVelocity = Mathf.Lerp(runVelocity, 0, runDecel);

        UpdateRunVelocity(input);

        Vector3 velocity = rigidBody.velocity;
        rigidBody.velocity = Vector3.zero;
        rigidBody.velocity = transform.up * runVelocity;

        rigidBody.AddTorque(turnForce * turnAccel * -1);
    }

    protected virtual void UpdateRunVelocity(Vector2 input)
    {
        if (input.y > 0)
        {
            runVelocity = Mathf.Lerp(runVelocity, forwardMax, forwardAccel);
        }
        else if (input.y < 0)
        {
            runVelocity = Mathf.Lerp(runVelocity, reverseMax * -1, reverseAccel);
        }
    }

    public float Velocity
    {
        get { return runVelocity; }
    }
    public float TurnForce
    {
        get { return turnForce; }
    }
}
