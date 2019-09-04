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

    // Start is called before the first frame update
    void Start()
    {
        int y = 0;
        for (int x = 0; x < amount && y < amount * 20; y++)
        {
            Vector3 location = new Vector3(Random.Range(-500, 500), transform.position.y, Random.Range(-500, 500));
            if (!Physics.CheckBox(location,new Vector3(1,1,1),new Quaternion(0,0,0,0), 1 << LayerMask.NameToLayer("Solid")) && Physics.CheckBox(location - new Vector3(0,4,0) , new Vector3(1, 3, 1), new Quaternion(0, 0, 0, 0), 1 << LayerMask.NameToLayer("Solid")) )
            {
                int randomInt = Random.Range(0,100);
                if (randomInt < 60)
                {
                    Instantiate(rareArm, location, new Quaternion(0, 0, 0, 0), this.transform);
                    x++;
                }
                else if (randomInt < 85)
                {
                    Instantiate(epicArm, location, new Quaternion(0, 0, 0, 0), this.transform);
                    x++;
                }
                else if (randomInt < 100)
                {
                    Instantiate(legendaryArm, location, new Quaternion(0, 0, 0, 0), this.transform);
                    x++;
                }
            }
        }
    }
}
