using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour {

    public string horizontalAxisName = "Horizontal";
    public string verticalAxisName = "Vertical";

    public Rigidbody2D rigidBody;
    public float turnAccel;
    public float forwardAccel;
    public float reverseAccel;
    public float turnMax;
    public float forwardMax;
    public float reverseMax;
    public float runDecel;

    private float runVelocity = 0f;
    private float turnForce = 0f;

    private CameraFollow cameraFollow;

    void Awake()
    {
        cameraFollow = Camera.main.GetComponent<CameraFollow>();
    }

	void Update () {
        cameraFollow.UpdateCamera(transform);
        GetInput();
        ApplyMovement();
        
	}

    private void GetInput()
    {
        turnForce = Input.GetAxis(horizontalAxisName);
        float vertical = Input.GetAxis(verticalAxisName);
        runVelocity = Mathf.Lerp(runVelocity, 0, runDecel);

        if (vertical > 0)
            runVelocity = Mathf.Lerp(runVelocity, forwardMax, forwardAccel);
        else if (vertical < 0)
            runVelocity = Mathf.Lerp(runVelocity, reverseMax * -1, reverseAccel);

        //Debug.Log(runVelocity);
    }

    private void ApplyMovement()
    {
        Vector3 velocity = rigidBody.velocity;
        rigidBody.velocity = Vector3.zero;
        rigidBody.velocity = transform.up * runVelocity;

        //Debug.Log(transform.forward * runVelocity);
        //Debug.Log(rigidBody.velocity);

        rigidBody.AddTorque(turnForce * turnAccel * -1);
    }
}
