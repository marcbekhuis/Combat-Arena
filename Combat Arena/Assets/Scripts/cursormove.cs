using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursormove : MonoBehaviour
{
    public Rigidbody rb;
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
        MoveAllowed = true;
        if (cursorvisibility == false)
        {
            Cursor.visible = false;
        }
        rotateHor = player.transform.localRotation.x;
        rotateVer = player.transform.localRotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxis(Xaxis));
        if (MoveAllowed == true && (Input.GetAxis(Xaxis) ==0 || Input.GetAxis(Yaxis)==0))
        {
            rotateHor += Sensitivity * Input.GetAxis(Xaxis);
            rotateVer += Sensitivity * Input.GetAxis(Yaxis);
            Vector3 rotation = new Vector3(rotateHor, rb.transform.rotation.y, rotateVer);

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
