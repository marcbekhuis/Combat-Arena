using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartPickup : MonoBehaviour
{
    Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        PlayerCombat combat;
        if ((combat = collision.gameObject.GetComponent<PlayerCombat>()) != null)
        {
            if (combat.leftArm == null)
            {
                rigidbody.gameObject.transform.parent = combat.gameObject.transform;
                combat.leftArm = rigidbody;
                rigidbody.constraints = RigidbodyConstraints.FreezePosition;
                transform.localPosition = new Vector3(-0.7f,1,0);
                transform.localRotation = new Quaternion(0,0,0,0);
                Destroy(this);
            }
            else if (combat.rightArm == null)
            {
                rigidbody.gameObject.transform.parent = combat.gameObject.transform;
                combat.rightArm = rigidbody;
                rigidbody.constraints = RigidbodyConstraints.FreezePosition;
                transform.localPosition = new Vector3(0.7f, 1, 0);
                transform.localRotation = new Quaternion(0, 0, 0, 0);
                Destroy(this);
            }
        }
    }
}
