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

	void Update () {
		
	}

    private void GetInput()
    {
        float horizontal = Input.GetAxis(horizontalAxisName);
        float vertical = Input.GetAxis(verticalAxisName);

        //rigidBody.velocity.y = Mathf.Lerp(rigidBody.velocity.y, forwardMax, forwardAccel);
        rigidBody.AddForce(new Vector2(horizontal, vertical));
    }
}
