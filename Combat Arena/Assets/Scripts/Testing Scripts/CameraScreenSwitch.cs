﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScreenSwitch : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    public bool Horizontal = false;

    private void Start()
    {
        if (HorizontalTrigger.Horizontal == true)
        {
            Horizontal = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(HorizontalTrigger.Horizontal);
        if (Horizontal)
        {
            ChangeScreen();
        }
    }

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
