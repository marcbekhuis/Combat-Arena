using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBodyParts : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody bodyPart;
        if (collision.gameObject.name == "LeftArm" || collision.gameObject.name == "RightArm")
        {
            if ((bodyPart = collision.gameObject.GetComponent<Rigidbody>()) != null)
            {
                bodyPart.constraints = RigidbodyConstraints.None;
                bodyPart.gameObject.transform.parent = null;
            }
        }
    }
}
