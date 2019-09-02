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
        if (Combat != null)
        {
            if (collision.gameObject.name == "LeftArm" || collision.gameObject.name == "RightArm")
            {
                if ((bodyPart = collision.gameObject.GetComponent<Rigidbody>()) != null && Combat.combat)
                {
                    if (bodyPart.transform.parent != this.transform.parent)
                    {
                        bodyPart.constraints = RigidbodyConstraints.None;
                        PlayerCombat temp;
                        if ((temp = bodyPart.transform.GetComponentInParent<PlayerCombat>()) != null)
                        {
                            if (temp.rightArm == bodyPart)
                            {
                                temp.rightArm = null;
                            }
                            else if (temp.leftArm == bodyPart)
                            {
                                temp.leftArm = null;
                            }
                        }
                        bodyPart.gameObject.transform.parent = null;

                        healthscript.healthloss();
                    }
                }
            }
        }
    }
}
