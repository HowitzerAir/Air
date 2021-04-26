using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightModel : MonoBehaviour
{
    public float airDensity;
    public Rigidbody aircraft;
    float engineThrust;
    float drag;
    public float lift;
    float turn;
    float pitch;
    static public float speed;
    public float wingarea;
    float xacc;
    float yacc;
    float zacc;
    public float weight;
    public float CL;
    public float surfacedrag;
    float AoA;
    Vector3 aircraftRotation;
    Vector3 aircraftTracking;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        aircraftRotation = transform.TransformDirection(transform.forward);
        aircraftTracking = transform.TransformVector(Vector3.forward);

        print("A/C Rotation: " + aircraftRotation);
        print("A/C Tracking: " + aircraftTracking);

        AoA = Vector3.Angle(aircraftRotation, aircraftTracking);
        print("AoA: " + AoA);
        speed = aircraft.velocity.magnitude;
        lift = ((airDensity * speed) / 2) * wingarea;

        aircraft.AddRelativeForce(0, lift, 0);
        aircraft.AddRelativeForce(0, 0, (engineScript.propThrust*0.3864f));
        print(aircraft.velocity + "m/s");

        if (Controlls.bankCommand > 0)
        {
            aircraft.AddTorque(0, 25, 0);
        }
        else if (Controlls.bankCommand < 0)
        {
            aircraft.AddTorque(0, -25, 0);
        }
        else
        {
            aircraft.AddTorque(0, 0, 0);
        }

        if (Controlls.pitchCommand > 0)
        {
            aircraft.AddTorque(0, 0, 25);
        }
        else if (Controlls.pitchCommand < 0)
        {
            aircraft.AddTorque(0, 0, -25);
        }
        else
        {
            aircraft.AddTorque(0, 0, 0);
        }



    }
}
