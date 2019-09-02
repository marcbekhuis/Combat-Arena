using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBodyParts : MonoBehaviour
{
    public PlayerCombat Combat;
    public HealthScript healthscript;
    public Bodypart bodypartSelf;

    private void Start()
    {
        bodypartSelf = GetComponent<Bodypart>();
        HealthScript[] healthScripts = FindObjectsOfType<HealthScript>();
        foreach (var healthScript in healthScripts)
        {
            if (healthScript.transform.parent != Combat.transform.parent)
            {
                healthscript = healthScript;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Combat != null && Combat.combat)
        {
            if (collision.transform.parent == healthscript.transform || collision.transform == healthscript.transform)
            {
                if (collision.gameObject.name == "LeftArm" || collision.gameObject.name == "RightArm")
                {
                    Rigidbody bodyPartRB;
                    if ((bodyPartRB = collision.gameObject.GetComponent<Rigidbody>()) != null)
                    {
                        Bodypart bodypartEnemy = collision.gameObject.GetComponent<Bodypart>();
                        if (bodypartEnemy.health - bodypartSelf.damage <= 0)
                        {
                            bodyPartRB.constraints = RigidbodyConstraints.None;
                            PlayerCombat temp;
                            if ((temp = bodyPartRB.transform.GetComponentInParent<PlayerCombat>()) != null)
                            {
                                if (temp.rightArm == bodyPartRB)
                                {
                                    temp.rightArm = null;
                                }
                                else if (temp.leftArm == bodyPartRB)
                                {
                                    temp.leftArm = null;
                                }
                            }
                            bodyPartRB.gameObject.transform.parent = null;
                            bodypartEnemy.health -= bodypartSelf.damage;
                        }
                        else
                        {
                            bodypartEnemy.health -= bodypartSelf.damage;
                        }
                    }
                }
                else if (collision.gameObject.name == "Head")
                {
                    Bodypart bodypartEnemy = collision.gameObject.GetComponent<Bodypart>();
                    if (bodypartEnemy.health - bodypartSelf.damage <= 0)
                    {
                        bodypartEnemy.health -= bodypartSelf.damage;
                        healthscript.Gameover();
                    }
                    else
                    {
                        bodypartEnemy.health -= bodypartSelf.damage;
                    }
                }
                healthscript.healthlose(bodypartSelf.damage);
            }
        }
    }
}
