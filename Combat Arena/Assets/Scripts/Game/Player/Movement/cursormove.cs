using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursormove : MonoBehaviour
{
    public Rigidbody player;
    [Space]
    public string Xaxis = "Mouse X";
    public string Yaxis = "Mouse Y";
    [Space]
    public bool MoveAllowed;
    public bool cursorvisibility;
    public float Sensitivity;
    float rotateHor;
    float rotateVer;

    private void Start()
    {
        //if game starts the mouse cursor will be invisible
        MoveAllowed = true;
        if (!cursorvisibility)
        {
            Cursor.visible = false;
        }
        rotateHor = player.transform.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveAllowed == true)
        {
            //the rotationhor and ver + the sensity * the input so it knows the sensitivity
            rotateHor += Sensitivity * Input.GetAxis(Xaxis);
            rotateVer += Sensitivity * Input.GetAxis(Yaxis);

            if (rotateVer >= 80)
            {
                rotateVer = 80;
            }
            else if (rotateVer <= -80)
            {
                rotateVer = -80;
            }
            //the cursor move
            player.transform.eulerAngles = new Vector3(0, rotateHor, 0);
            transform.eulerAngles = new Vector3(-rotateVer, rotateHor, 0);
        }
    }
}
