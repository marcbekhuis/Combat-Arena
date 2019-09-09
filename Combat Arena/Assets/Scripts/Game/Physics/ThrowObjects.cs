using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObjects : MonoBehaviour
{
    public Transform[] players;
    public Transform[] playerCameras;
    [Space]

    public float throwingforce;

    bool hasPlayer = false;
    bool IsCarrying = false;
    private bool touch = false;
    public int damage = 10;

    // Update is called once per frame
    void Update()
    {
        for (int x = 0; x < players.Length; x++)
        {
            float distance = Vector3.Distance(gameObject.transform.position, players[x].position);


            //checks if distance is less than 2.5 so the player can pick something up
            if (distance <= 2.5f)
            {
                hasPlayer = true;
            }
            else
            {
                hasPlayer = false;
            }
            //checks if hasPlayer true is and if player pressed E or A
            if (hasPlayer && ((x == 0 && Input.GetKeyDown(KeyCode.E)) || (x == 1 && Input.GetKeyDown(KeyCode.JoystickButton0))))
            {
                GetComponent<Rigidbody>().isKinematic = true;
                transform.parent = playerCameras[x];
                IsCarrying = true;
            }
            //checks if the player picked something up
            if (IsCarrying == true)
            {
                if (touch)
                {
                    GetComponent<Rigidbody>().isKinematic = false;
                    transform.parent = null;
                    IsCarrying = false;
                    touch = false;
                }
                //checks if the player pressed left click or joystick 5 to throw the object
                if ((x == 0 && Input.GetKeyDown(KeyCode.Mouse0)) || (x == 1 && Input.GetKeyDown(KeyCode.JoystickButton5)))
                {
                    GetComponent<Rigidbody>().isKinematic = false;
                    transform.parent = null;
                    IsCarrying = false;
                    GetComponent<Rigidbody>().AddForce(playerCameras[x].forward * Random.Range(400, 900));
                }
                //checks if the player pressed right click or joystick 2 to drop the object
                else if ((x == 0 && Input.GetKeyDown(KeyCode.Mouse1)) || (x == 1 && Input.GetKeyDown(KeyCode.JoystickButton2)))
                {
                    GetComponent<Rigidbody>().isKinematic = false;
                    transform.parent = null;
                    IsCarrying = false;
                }


            }
        }
    }
    
}
