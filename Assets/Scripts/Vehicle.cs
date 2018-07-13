using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(VehicleController))]
[RequireComponent(typeof(VehicleMovement))]
[RequireComponent(typeof(Rigidbody2D))]
public class Vehicle : MonoBehaviour {




    private VehicleController moveController;
    private VehicleMovement movement;
    private Rigidbody2D rigidBody;

    void Awake()
    {
        VehicleAwake();
    }

    protected void VehicleAwake()
    {
        moveController = GetComponent<VehicleController>();
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
        Debug.Log(name);
        Vector2 input = moveController.GetInput();
        movement.ApplyMovement(rigidBody, input);
    }
}
