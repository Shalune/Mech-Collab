using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveController))]
[RequireComponent(typeof(VehicleMovement))]
[RequireComponent(typeof(Rigidbody2D))]
public class Vehicle : MonoBehaviour {




    private MoveController moveController;
    private VehicleMovement movement;
    private Rigidbody2D rigidBody;

    void Awake()
    {
        VehicleAwake();
    }

    protected void VehicleAwake()
    {
        moveController = GetComponent<MoveController>();
        movement = GetComponent<VehicleMovement>();
        rigidBody = GetComponent<Rigidbody2D>();
        Debug.Log(rigidBody.gameObject.name);
    }

	void Update()
    {
        VehicleUpdate();
    }

    protected void VehicleUpdate()
    {
        Vector2 input = moveController.GetInput();
        movement.ApplyMovement(rigidBody, input);
    }
}
