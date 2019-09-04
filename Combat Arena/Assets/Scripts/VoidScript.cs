using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidScript : MonoBehaviour
{
    public HealthScript health;

    void OnTriggerEnter(Collider other)
    {
        if ((health = other.gameObject.GetComponent<HealthScript>()) != null)
        {
            health.Gameover();
        }
    }
}
