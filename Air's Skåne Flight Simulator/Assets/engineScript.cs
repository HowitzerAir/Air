using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engineScript : MonoBehaviour
{

    public bool engineOn; //Motor på och av
   
    #region engineVariables
    float throttle; //Gas
    public static float propThrust; //Nummer för flightmodel.
    public float idleRPM;//Konstanter för motortyp
    float desiredRPM; //Nummer baserat på throttleposition
    public float maxRPM; //Konstanter för motortyp, vid max throttle
    #endregion

    #region ThrustVariables
    public float expectedThrust;
    public static float engRpm; //Engine RPM, nummer för motor, också med i uträkning
    float propBladeArea; //Nummer för uträkningar
    int propNumber; //Mer nummer för uträkningar    
    float engineSpeed; //Nummer för uträkning
    float throttleRPM;
    #endregion 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyUp(KeyCode.I))
        {
            engineOn = true;
        }
        else if (engineOn && Input.GetKeyUp(KeyCode.I))
        {
            engineOn = false;
        }
        
        if(throttle > 100)
        {
            throttle = 100;
        }
        else if(throttle < 0)
        {
            throttle = 0;
        }
        else
        {
            if(Controlls.throttleCommand == 1)
            {
                print(throttle);
                throttle++;
            }
            else if(Controlls.throttleCommand == -1)
            {
                print(throttle);
                throttle--; 
            }
            else
            {
                
            }
        }

        if (engineOn)
        {
            print("Engine On");
            print(engRpm + "RPM");
            if(engRpm < idleRPM)
            {
                engRpm++;
            }

            desiredRPM = idleRPM + ((maxRPM - idleRPM) * (throttle / 100));

            if(engRpm < desiredRPM)
            {
                engRpm++;
            }
            if (engRpm > desiredRPM)
            {
                engRpm--;
            }
            throttleRPM = engRpm - idleRPM;
        }
        
        print(throttleRPM + "thrPRM");
        propThrust = (throttleRPM / maxRPM) * 8200;

    }
}
