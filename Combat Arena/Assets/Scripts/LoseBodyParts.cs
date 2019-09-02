using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBodyParts : MonoBehaviour
{
    public PlayerCombat Combat;
    public HealthScript healthscript;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody bodyPart;
        if (collision.gameObject.name == "LeftArm" || collision.gameObject.name == "RightArm")
        {
            if ((bodyPart = collision.gameObject.GetComponent<Rigidbody>()) != null && Combat.combat)
            {
                if (bodyPart.transform.parent != this.transform.parent)
                {
                    bodyPart.constraints = RigidbodyConstraints.None;
                    bodyPart.gameObject.transform.parent = null;

                    healthscript.healthloss();
                }
            }
        }
    }
}
