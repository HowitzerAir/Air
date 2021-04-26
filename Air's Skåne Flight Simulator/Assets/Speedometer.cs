using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedometer : MonoBehaviour
{
    private const float MAX_SPEED_ANGLE = -300f;
    private const float ZERO_SPEED_ANGLE = 0f;

    private Transform needleTransform;

    private float speedMax;
    private float speed;

    GameObject aircraft;

    private void Awake()
    {
        needleTransform = transform.Find("Rotation");

        speed = FlightModel.speed;
        speedMax = 200f;
    }

    private void Update()
    {

        speed += 30f * Time.deltaTime;
        if (speed > speedMax) speed = speedMax;

        needleTransform.eulerAngles = new Vector3(0, 0, GetSpeedRotation());

        aircraft = GameObject.FindGameObjectWithTag("Player");

    }
    
    private float GetSpeedRotation()
    {
        float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;

        float speedNormalized = speed / speedMax;

        return ZERO_SPEED_ANGLE - speedNormalized * totalAngleSize;
    }

}
