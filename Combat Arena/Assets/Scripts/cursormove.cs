﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursormove : MonoBehaviour
{
    public Rigidbody rb;
    public Rigidbody player;

    public bool MoveAllowed;
    public bool cursorvisibility;
    public float Sensitivity;
    float rotateHor;
    float rotateVer;

    private void Start()
    {
        MoveAllowed = true;
        if(cursorvisibility == false)
        {
            Cursor.visible = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveAllowed == true)
        {
            rotateHor += Sensitivity * Input.GetAxis("Mouse X");
            rotateVer += Sensitivity * Input.GetAxis("Mouse Y");
            Vector3 rotation = new Vector3(rotateHor, rb.transform.position.y, rotateVer);

            if (rotateVer >= 80)
            {
                rotateVer = 80;
            }

            if (rotateVer <= -80)
            {
                rotateVer = -80;
            }

           
            player.transform.eulerAngles = new Vector3(0, rotateHor, 0);
            transform.eulerAngles = new Vector3(-rotateVer, rotateHor, 0);
        }
    }
}