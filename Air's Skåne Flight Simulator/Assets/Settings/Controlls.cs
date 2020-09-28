using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlls : MonoBehaviour
{
    //Kontrollerna kommer att vara globala, så att det går att fixa dem utan att röra movement eller sådant.
    //Kommentarer kommer jag också att skriva på svenska.
    //Skall göra så att man själv kan ändra vilka knappar som gör vad.

    public static int throttleCommand; //Kontrollera gasen. + är Höja, - är sänka.
    public static int pitchCommand; //Kontrollera höjdroder.
    public static int bankCommand; //Kontrollera sväng/svängvinkel, + är höger, - är vänster
    public static int yawCommand; //Kontrollera planet på marken/från sida till sida.
    public static int flapsCommand; //Kontrollera klaffarna
    

    public enum ThrottleControls { WOchS, PilUpOchNer, ShiftOchCtrl } //Med denna ändrar man vilka knappar som används för gas.
    public ThrottleControls GasKontroll; //

    public enum FlightControlls { wasdFörPitchOchBank = 1, PiltangenterFörPitchOchBank = 2}
    public FlightControlls KontrollLäge; //Vilka knappar som används för kontroll.





    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (KontrollLäge == FlightControlls.PiltangenterFörPitchOchBank)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                pitchCommand = 1;
            }
            else if(Input.GetKey(KeyCode.DownArrow))
            {
                pitchCommand = -1;
            }
            else
            {
                pitchCommand = 0;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                bankCommand = 1;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                bankCommand = -1;
            }
            else
            {
                bankCommand = 0;
            }

            print(pitchCommand);
            print(bankCommand);
            KontrollCheck(Input.GetKey(KeyCode.DownArrow), Input.GetKey(KeyCode.UpArrow), pitchCommand);
            KontrollCheck(Input.GetKey(KeyCode.RightArrow), Input.GetKey(KeyCode.LeftArrow), bankCommand);
            KontrollCheck(Input.GetKey(KeyCode.Period), Input.GetKey(KeyCode.Comma), yawCommand);
        }
        else if(KontrollLäge == FlightControlls.wasdFörPitchOchBank)
        {
            KontrollCheck(Input.GetKey(KeyCode.S), Input.GetKey(KeyCode.W), pitchCommand);
            KontrollCheck(Input.GetKey(KeyCode.D), Input.GetKey(KeyCode.A), bankCommand);
            KontrollCheck(Input.GetKey(KeyCode.E), Input.GetKey(KeyCode.Q), yawCommand);
        }
        if(Input.GetKey(KeyCode.W))
        {
            //print("Pitch Down");
        }
        if(pitchCommand == -1)
        {
            //print("Pitch Up");
        }

        if (GasKontroll == ThrottleControls.ShiftOchCtrl)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                throttleCommand = 1;
            }
            else if (Input.GetKey(KeyCode.LeftControl))
            {
                throttleCommand = -1;
            }
            else
            {
                throttleCommand = 0;
            }
        }
    }

    #region KontrolMetoder
    void KontrollCheck(bool CommandUp, bool CommandNer, int commandToChange)
    {
        if (CommandUp)
        {
            commandToChange = 1;
        }
        else if (CommandNer)
        {
            commandToChange = -1;
        }
        else
        {
            commandToChange = 0;
        }
    }
    #endregion
}
