using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCenterOfMass : MonoBehaviour
{
    public Vector3 centerOfMass;

    // Start is called before the first frame update
    void Start()
    {
        // changes the center of mass from the rigidbody to the wanted location
        GetComponent<Rigidbody>().centerOfMass = centerOfMass;
    }
}
