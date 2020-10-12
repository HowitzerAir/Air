using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleScript : MonoBehaviour
{
    public float RPM = engineScript.engRpm/13.3333f;
    GameObject subjectEngine;

    // Start is called before the first frame update
    void Start()
    {
        subjectEngine = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion RPM = Quaternion.Euler(0, 0, 0);
        transform.rotation = RPM;
    }
}
