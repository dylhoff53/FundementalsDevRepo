using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : SteeringBehavior
{
    public Kinematic character;
    public GameObject target;


    float wanderOffset;
    float wanderRadius;
    float wanderRate;
    float maxAcceleration = 15f;
    float wanderOrientation;

    protected virtual Vector3 getTargetOrientation()
    {
        return target.transform.position;
    }

    public override SteeringOutput getSteering()
    {


        SteeringOutput result = new SteeringOutput();
        Vector3 targetOrientation = getTargetOrientation();
        if (targetOrientation == Vector3.positiveInfinity)
        {
            return null;
        }
        return null;
    }
}
