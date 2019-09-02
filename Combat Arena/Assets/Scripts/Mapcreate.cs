using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapcreate : MonoBehaviour
{

    public GameObject trees;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(trees, new Vector3(Random.Range(-50f, 50), 7.41f, Random.Range(-50f, 50)), new Quaternion(0, 0, 0, 0));

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
