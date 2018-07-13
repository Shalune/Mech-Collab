using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIVehicleController : VehicleController
{

    protected Vector2 destination;

    override public Vector2 GetInput()
    {
        return new Vector2(1, 1);
    }

    //protected float 
}
