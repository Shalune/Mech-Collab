using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonScript : MonoBehaviour {

	public Rigidbody2D lemonz;

	void Start () {
		lemonz.AddForce (transform.up * 600);
	}

	void Update () {
		float ecks = Mathf.Abs(lemonz.velocity.x);
		float why = Mathf.Abs(lemonz.velocity.y);
		float velo = ecks + why;
		if (velo < 1) {
			Destroy (lemonz.gameObject);
		}
	}
}
