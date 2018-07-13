using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVehicle : Vehicle {

    protected CameraFollow cameraFollow;
	public GameObject sirhonkleton;

    void Awake()
    {
        VehicleAwake();
        cameraFollow = Camera.main.GetComponent<CameraFollow>();
    }

	void Update()
    {
        VehicleUpdate();
        cameraFollow.UpdateCamera(transform);

		//HONKHONKHONK
		//sirhonkleton.transform.parent = transform;
    }
}
