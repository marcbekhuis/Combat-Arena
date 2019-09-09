using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonVieuw : MonoBehaviour
{
    public GameObject camera;
    public KeyCode switchCameraMode = KeyCode.F5;
    int mode = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //checks if f5 key is pressed
        if (Input.GetKeyDown(switchCameraMode))
        {

            //checks the mode and change the camera position to either first person, third person of in front of you
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
