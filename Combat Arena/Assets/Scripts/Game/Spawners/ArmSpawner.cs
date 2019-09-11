using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmSpawner : MonoBehaviour
{
    public GameObject rareArm;
    public GameObject epicArm;
    public GameObject legendaryArm;
    [Space]
    public int amount = 10;
    int armsSpawned = 0;

    // Start is called before the first frame update
    void Start()
    {
        // loop to spawn the wanted amount of arms or if the loop limit is reached
        for (int y = 0; armsSpawned < amount && y < amount * 30; y++)
        {
            Vector3 location = new Vector3(Random.Range(-500, 500), transform.position.y, Random.Range(-500, 500));
            // spawns an arm if not overlapping an object and an object underneath
            if (!Physics.CheckBox(location,new Vector3(1,1,1),new Quaternion(0,0,0,0), 1 << LayerMask.NameToLayer("Solid")) && Physics.CheckBox(location - new Vector3(0,4,0) , new Vector3(1, 3, 1), new Quaternion(0, 0, 0, 0), 1 << LayerMask.NameToLayer("Solid")) )
            {
                // random number get generated and then picks a rarety arm based on the number
                int randomInt = Random.Range(0,100);
                if (randomInt < 60)
                {
                    Instantiate(rareArm, location, new Quaternion(0, 0, 0, 0), this.transform);
                    armsSpawned++;
                }
                else if (randomInt < 85)
                {
                    Instantiate(epicArm, location, new Quaternion(0, 0, 0, 0), this.transform);
                    armsSpawned++;
                }
                else if (randomInt < 100)
                {
                    Instantiate(legendaryArm, location, new Quaternion(0, 0, 0, 0), this.transform);
                    armsSpawned++;
                }
            }
        }
    }

    private void Update()
    {
        // does the same as the above if the wanted number of arms hasn't been reached yet.
        if (armsSpawned < amount)
        {
            Vector3 location = new Vector3(Random.Range(-500, 500), transform.position.y, Random.Range(-500, 500));
            if (!Physics.CheckBox(location, new Vector3(3, 3, 3), new Quaternion(0, 0, 0, 0), 1 << LayerMask.NameToLayer("Solid")) && Physics.CheckBox(location - new Vector3(0, 5, 0), new Vector3(3, 7, 3), new Quaternion(0, 0, 0, 0), 1 << LayerMask.NameToLayer("Solid")))
            {
                int randomInt = Random.Range(0, 100);
                if (randomInt < 60)
                {
                    Instantiate(rareArm, location, new Quaternion(0, 0, 0, 0), this.transform);
                    armsSpawned++;
                }
                else if (randomInt < 85)
                {
                    Instantiate(epicArm, location, new Quaternion(0, 0, 0, 0), this.transform);
                    armsSpawned++;
                }
                else if (randomInt < 100)
                {
                    Instantiate(legendaryArm, location, new Quaternion(0, 0, 0, 0), this.transform);
                    armsSpawned++;
                }
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        // Draw a semitransparent red cube at the transforms position
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(3, 3, 3));
        // Draw a semitransparent green cube at the transforms position
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawCube(new Vector3(transform.position.x, transform.position.y, transform.position.z) - new Vector3(0, 5, 0), new Vector3(3, 7, 3));
    }
}
