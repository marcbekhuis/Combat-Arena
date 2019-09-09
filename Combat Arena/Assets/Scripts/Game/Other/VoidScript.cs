using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidScript : MonoBehaviour
{
    public HealthScript health;

    void OnTriggerEnter(Collider other)
    {
        // shows the gameover canvas when the player hits the box
        if ((health = other.gameObject.GetComponentInParent<HealthScript>()) != null)
        {
            health.Gameover();
        }
    }
}
