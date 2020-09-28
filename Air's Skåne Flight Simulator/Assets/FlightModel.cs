using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightModel : MonoBehaviour
{
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
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        lift = wingarea * speed;

        aircraft.AddForce(0, lift, 0);
    }
}
