using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : VehicleController
{

    public string horizontalAxisName = "Horizontal";
    public string verticalAxisName = "Vertical";

    override public Vector2 GetInput()
    {
        return new Vector2(Input.GetAxis(horizontalAxisName), Input.GetAxis(verticalAxisName));
    }
}
