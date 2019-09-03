using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Westernhay : MonoBehaviour
{
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.angularVelocity = rigidbody.rotation * new Vector3(10,rigidbody.velocity.y, rigidbody.velocity.z);
        if (Random.Range(0,50) < 2)
        {
            rigidbody.AddForce(rigidbody.rotation * new Vector3(0,5,0));
        }
    }
}
