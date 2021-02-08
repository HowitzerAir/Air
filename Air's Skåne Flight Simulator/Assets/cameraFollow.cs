using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject followAircraft;

    void Start()
    {
        followAircraft = GameObject.FindGameObjectWithTag("PlayerAircraft");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(followAircraft.transform.position.x, followAircraft.transform.position.y+10, followAircraft.transform.position.z);
    }
}
