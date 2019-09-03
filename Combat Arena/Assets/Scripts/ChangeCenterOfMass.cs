using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCenterOfMass : MonoBehaviour
{
    public Vector3 centerOfMass;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = centerOfMass;
    }
}
