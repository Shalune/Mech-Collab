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
        
	}

    public Vector2 GetInput()
    {
        return new Vector2(Input.GetAxis(horizontalAxisName), Input.GetAxis(verticalAxisName));
    }
}
