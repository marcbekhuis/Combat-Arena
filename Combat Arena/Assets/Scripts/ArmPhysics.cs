using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmPhysics : MonoBehaviour
{
    public float speedY = 0.7f;

    Rigidbody arm;

    private void Start()
    {
        arm = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // tries to lower the arm down so its not floating up in the air.
        if ((arm.transform.rotation * arm.angularVelocity).x < 0.1 && (arm.transform.rotation * arm.angularVelocity).x > -0.1)
        {
            if (arm.transform.rotation.x > 0.1)
            {
                arm.AddTorque(arm.transform.rotation * new Vector3(-0.7f, 0, 0));
            }
            else if (arm.transform.rotation.x < -0.1)
            {
                arm.AddTorque(arm.transform.rotation * new Vector3(0.7f, 0, 0));
            }
        }
    }
}
