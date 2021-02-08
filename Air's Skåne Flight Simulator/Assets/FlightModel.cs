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
    public float speed;
    public float wingarea;
    float xacc;
    float yacc;
    float zacc;
    public float weight;
    public float CL;
    public float surfacedrag;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speed = aircraft.velocity.magnitude;
        lift = ((airDensity * speed) / 2) * wingarea;

        aircraft.AddRelativeForce(0, lift, 0);
        aircraft.AddRelativeForce(0, 0, engineScript.propThrust);
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



    }
}
