using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedPack : MonoBehaviour
{
    HealthScript health;
    public MedPackSpawner medPackSpawner;

    void OnTriggerEnter(Collider other)
    {
        // Heals the player up to 1000.
        if ((health = other.gameObject.GetComponentInParent<HealthScript>()) != null)
        {
            health.Heal(100);
            medPackSpawner.medPacksSpawned--;
            Destroy(this.gameObject);
        }
    }
}
