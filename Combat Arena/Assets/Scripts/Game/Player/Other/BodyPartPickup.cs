﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartPickup : MonoBehaviour
{
    Rigidbody rigidbody;
    public AudioSource source;
    public AudioClip clip;
    PlayerCombat combat;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        // checks if collider has playercombet
        if ((combat = collision.gameObject.GetComponent<PlayerCombat>()) != null)
        {
            // checks if you lost one of your arms
            if (combat.leftArm == null && combat.rightArm != rigidbody)
            {
                // gives the arm to the player and sends the needed variables
                rigidbody.gameObject.transform.parent = combat.gameObject.transform;
                combat.leftArm = rigidbody;
                rigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                transform.localPosition = new Vector3(-0.7f,1,0);
                transform.localRotation = new Quaternion(0,0,0,0);
                rigidbody.centerOfMass = new Vector3(0, 0, 0);
                LoseBodyParts loseBody;
                if ((loseBody = GetComponent<LoseBodyParts>()) != null)
                {
                    loseBody.Combat = combat;
                    HealthScript[] healthScripts = FindObjectsOfType<HealthScript>();
                    foreach (var healthScript in healthScripts)
                    {
                        if (healthScript.transform != combat.transform)
                        {
                            loseBody.healthscript = healthScript;
                        }
                    }
                }
                source.PlayOneShot(clip);
                Destroy(this);
            }
            else if (combat.rightArm == null && combat.leftArm != rigidbody)
            {
                // gives the arm to the player and sends the needed variables
                rigidbody.gameObject.transform.parent = combat.gameObject.transform;
                combat.rightArm = rigidbody;
                rigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                transform.localPosition = new Vector3(0.7f, 1, 0);
                transform.localRotation = new Quaternion(0, 0, 0, 0);
                rigidbody.centerOfMass = new Vector3(0,0,0);
                LoseBodyParts loseBody;
                if ((loseBody = GetComponent<LoseBodyParts>()) != null)
                {
                    loseBody.Combat = combat;
                    HealthScript[] healthScripts = FindObjectsOfType<HealthScript>();
                    foreach (var healthScript in healthScripts)
                    {
                        if (healthScript.transform != combat.transform)
                        {
                            loseBody.healthscript = healthScript;
                        }
                    }
                }
                source.PlayOneShot(clip);
                Destroy(this);
            }
        }
    }
}
