using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Rigidbody leftArm;
    public Rigidbody rightArm;
    public KeyCode attack = KeyCode.Mouse0;

    float leftArmCooldown = 0;
    float rightArmCooldown = 0;
    public bool combat = false;

    // Start is called before the first frame update
    void Start()
    {
        leftArm.centerOfMass = new Vector3(0,0,0);
        rightArm.centerOfMass = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenuToggle.paused && !HealthScript.gameEnd)
        {
            if (Input.GetKeyDown(attack))
            {
                if (Random.Range(0, 50) < 25 && leftArmCooldown <= 0 && leftArm != null)
                {
                    leftArm.AddTorque(leftArm.transform.rotation * new Vector3(-10, 0, 0), ForceMode.Impulse);
                    Debug.Log("leftArm");
                    leftArmCooldown = 1;
                    combat = true;
                }
                else if (rightArmCooldown <= 0 && rightArm != null)
                {
                    rightArm.AddTorque(rightArm.transform.rotation * new Vector3(-10, 0, 0), ForceMode.Impulse);
                    Debug.Log("RightArm");
                    rightArmCooldown = 1;
                    combat = true;
                }
            }
            if (combat == true && (rightArmCooldown <= 0.05f && leftArmCooldown <= 0.05f))
            {
                combat = false;
            }
            rightArmCooldown -= Time.deltaTime;
            leftArmCooldown -= Time.deltaTime;
        }
    }
}
