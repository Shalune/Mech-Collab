using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIVehicleController : VehicleController
{

    override public Vector2 GetInput()
    {
        return new Vector2(1, 1);
    }
}
