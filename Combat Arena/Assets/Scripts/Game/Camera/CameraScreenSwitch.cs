using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScreenSwitch : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    public bool Horizontal = false;

    //checks if the horizontal trigger is horizontal so the boolean becomes true
    private void Start()
    {
        if (HorizontalTrigger.Horizontal == true)
        {
            Horizontal = true;
        }
    }

    // Update is called once per frame
    // if horizontal = true call ChangeScreen();
    void Update()
    {
        if (Horizontal)
        {
            ChangeScreen();
        }
    }


    //checks if horizontal = true so it change screen else it vertical
    public void ChangeScreen()
    {
        if (Horizontal)
        {
            cam1.rect = new Rect(0, 0.5f, 1, 0.5f);
            cam2.rect = new Rect(0, 0, 1, 0.5f);
        }
        else
        {
            cam1.rect = new Rect(0.5f, 0, 0.5f, 1);
            cam2.rect = new Rect(0, 0, 0.5f, 1);
        }
    }
}
