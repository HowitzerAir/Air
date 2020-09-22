using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlls : MonoBehaviour
{
    //Kontrollerna kommer att vara globala, så att det går att fixa dem utan att röra movement eller sådant.
    //Kommentarer kommer jag också att skriva på svenska.
    //Skall göra så att man själv kan ändra vilka knappar som gör vad.

    public static bool increaseThrottle; //Höja gas
    public static bool decreaseThrottle; // Sänka gas
    public static bool bankLeft; //Svänga vänster
    public static bool bankRight; // Svänga höger
    public static bool pitchUp; //Höja nosen
    public static bool pitchDown; //Sänka nosen
    public static bool yawLeft; //Yaw är axelns som ett rodder styr. Svänga vänster, oftast för att styra på marken
    public static bool yawRight; //Svänga höger.
    public static bool flapsUp; //Fäller upp/minksar flaps. Flaps är bitar på vingen som gör att man kan åka snabbare, men som också saktar ner flygplanet.
    public static bool flapsDown; //Sänker/ökar flaps.

    public enum ThrottleControls { WOchS, PilUpOchNer, ShiftOchCtrl } //Med denna ändrar man vilka knappar som används för gas.
    public ThrottleControls SelectedMode; //





    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*ThrottleControll[0] = string[3] {"W/S", "ArrowUp/Down", "Shift/Control"}; */
    }
}
