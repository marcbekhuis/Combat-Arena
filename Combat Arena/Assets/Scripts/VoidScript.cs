using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidScript : MonoBehaviour
{
    public HealthScript health;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if ((health = other.gameObject.GetComponentInParent<HealthScript>()) != null)
        {
            health.Gameover();
        }
    }
}
