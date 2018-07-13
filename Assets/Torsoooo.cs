using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Torsoooo : MonoBehaviour {

	public Rigidbody2D torsobody;
	public GameObject leftarm;
	public GameObject rightarm;
	public GameObject lemon;

	// Use this for initialization
	void Start () {
		//Destroy (lemon);
	}

	// Update is called once per frame
	void Update () {
		Vector2 mousewhat = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
		Vector2 wheremouse = mousewhat - torsobody.position;
		float intermediate = wheremouse.y / wheremouse.x;
		double whichway = Math.Atan(intermediate)*(180/Math.PI);

		float dirdir = Vector2.SignedAngle(wheremouse, torsobody.position);

		//------------------------------
		double thingy = torsobody.rotation - whichway;

		//Debug.Log (whichway);
		if (wheremouse.x > 0) {
			if (torsobody.rotation + 90 > whichway) {
				torsobody.MoveRotation (torsobody.rotation - 5);
				//torsobody.AddTorque(-1);
			}
			if (torsobody.rotation + 90 < whichway) {
				torsobody.MoveRotation (torsobody.rotation + 5);
				//torsobody.AddTorque (1);
			}
		}
		if (wheremouse.x < 0) {
			if (torsobody.rotation - 90 > whichway) {
				torsobody.MoveRotation (torsobody.rotation - 5);
				//torsobody.AddTorque(-1);
			}
			if (torsobody.rotation - 90 < whichway) {
				torsobody.MoveRotation (torsobody.rotation + 5);
				//torsobody.AddTorque (1);
			}
		}

		//-----------------------------------
		leftarm.transform.parent = transform;
		rightarm.transform.parent = transform;

		//-----------------------------------
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("bang");
			/*Vector3 lemonade = transform.position;
			lemonade.x = lemonade.;*/
			Instantiate(lemon, transform.position, transform.rotation);
		}

	}
}
