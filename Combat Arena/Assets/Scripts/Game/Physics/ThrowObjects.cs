using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObjects : MonoBehaviour
{
    public Transform[] players;
    public Transform[] playerCameras;
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

            if (distance <= 2.0f)
            {
                hasPlayer = true;
            }
            else
            {
                hasPlayer = false;
            }
            if (hasPlayer && Input.GetButtonDown("Use"))
            {
                GetComponent<Rigidbody>().isKinematic = true;
                transform.parent = playerCameras[x];
                IsCarrying = true;
            }
            if (IsCarrying == true)
            {
                if (touch)
                {
                    GetComponent<Rigidbody>().isKinematic = false;
                    transform.parent = null;
                    IsCarrying = false;
                    touch = false;
                }
                if (Input.GetMouseButtonDown(0))
                {
                    GetComponent<Rigidbody>().isKinematic = false;
                    transform.parent = null;
                    IsCarrying = false;
                    GetComponent<Rigidbody>().AddForce(playerCameras[x].forward * Random.Range(400, 900));
                }
                else if (Input.GetMouseButtonDown(1))
                {
                    GetComponent<Rigidbody>().isKinematic = false;
                    transform.parent = null;
                    IsCarrying = false;
                }


            }
        }
    }
    
}
