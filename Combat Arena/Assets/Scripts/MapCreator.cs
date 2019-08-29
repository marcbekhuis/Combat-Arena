using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{

    int walls = 10;
    // Start is called before the first frame update
    void Start()
    {
        GameObject cubes;
        GameObject wall;

        Color color = new Color(

            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            1

        );

        for (int i = 0; i < 40; i++)
        {
            cubes = GameObject.CreatePrimitive(PrimitiveType.Cube);

            cubes.transform.position = (new Vector3(Random.Range(-50f,50), 8.17f, Random.Range(-50f, 50)));
            cubes.transform.localScale = (new Vector3(Random.Range(5, 10), Random.Range(5, 10), Random.Range(5, 10)));
            cubes.GetComponent<Renderer>().material.color = color;
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
