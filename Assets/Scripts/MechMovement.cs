using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechMovement : VehicleMovement {

    public override void ApplyMovement(Rigidbody2D rigidBody, Vector2 input)
    {
        turnForce = input.x;
        runVelocity = Mathf.Lerp(runVelocity, 0, runDecel);

        if (input.y > 0)
        {
            runVelocity = Mathf.Lerp(runVelocity, forwardMax, forwardAccel);
        }
        else if (input.y < 0)
        {
            runVelocity = Mathf.Lerp(runVelocity, reverseMax * -1, reverseAccel);
        }

        Vector3 velocity = rigidBody.velocity;
        rigidBody.velocity = Vector3.zero;
        rigidBody.velocity = transform.up * runVelocity;

        rigidBody.AddTorque(turnForce * turnAccel * -1);
    }
}
