using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedPackSpawner : MonoBehaviour
{
    public GameObject medPack;
    [Space]
    public int maxAmount = 10;
    public int medPacksSpawned = 0;
    HealthScript player1;
    HealthScript player2;

    float cooldown = 0;

    // Start is called before the first frame update
    void Start()
    {
        HealthScript[] players = FindObjectsOfType<HealthScript>();
        player1 = players[0];
        player2 = players[1];
    }

    private void Update()
    {
        if (cooldown <= 0)
        {
            // spawns a medpack if 1 of the 2 players is under the 500 health
            if (medPacksSpawned < maxAmount && (player1.health < 500 || player2.health < 500))
            {
                Vector3 location = new Vector3(Random.Range(-500, 500), transform.position.y, Random.Range(-500, 500));
                if (!Physics.CheckBox(location, new Vector3(3, 3, 3), new Quaternion(0, 0, 0, 0), 1 << LayerMask.NameToLayer("Solid")) && Physics.CheckBox(location - new Vector3(0, 5, 0), new Vector3(3, 7, 3), new Quaternion(0, 0, 0, 0), 1 << LayerMask.NameToLayer("Solid")))
                {
                    GameObject temp = Instantiate(medPack, location, new Quaternion(0, 0, 0, 0), this.transform);
                    temp.GetComponent<MedPack>().medPackSpawner = this;
                    medPacksSpawned++;
                    cooldown = 60;
                }
            }
        }
        cooldown -= Time.deltaTime;
    }

    void OnDrawGizmosSelected()
    {
        // Draw a semitransparent blue cube at the transforms position
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(3, 3, 3));
        // Draw a semitransparent red cube at the transforms position
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawCube(new Vector3(transform.position.x, transform.position.y, transform.position.z) - new Vector3(0, 5, 0), new Vector3(3, 7, 3));
    }
}
