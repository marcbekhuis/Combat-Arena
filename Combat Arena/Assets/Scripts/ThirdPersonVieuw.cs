using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonVieuw : MonoBehaviour
{
    public GameObject camera;
    int mode = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            if (mode == 2)
            {
                camera.transform.localPosition = new Vector3(0f, 0.5f, 0.171f);
                camera.transform.localRotation = new Quaternion(0,0,0,0);
                mode = 0;
            }
            else if (mode == 0)
            {
                camera.transform.localPosition = new Vector3(0f, 0.5f, 6.176f);
                camera.transform.localRotation = new Quaternion(0,180,0,0);
                mode = 1;
                    }
            else if (mode == 1)
            {
                camera.transform.localPosition = new Vector3(0f, 0.5f, -6.176f);
                camera.transform.localRotation = new Quaternion(0, 0, 0, 0);
                mode = 2;
            }
        }
    }
}
