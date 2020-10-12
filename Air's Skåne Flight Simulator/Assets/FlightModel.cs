using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightModel : MonoBehaviour
{
    public float airDensity;
    public Rigidbody aircraft;
    float engineThrust;
    float drag;
    float lift;
    float turn;
    float pitch;
    public float speed;
    public float wingarea;
    float xacc;
    float yacc;
    float zacc;
    public float weight;
    public float CL;
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        lift = ((airDensity * speed) / 2) * wingarea;

        aircraft.AddForce(0, lift, 0);
        aircraft.AddForce(0, 0, engineScript.propThrust);
    }
}
