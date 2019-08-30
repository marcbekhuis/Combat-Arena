using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public string Xaxis = "HorizontalP1";
    public string Yaxis = "VerticalP1";
    [Space]
    public KeyCode jump = KeyCode.Space;
    [Space]
    Rigidbody rb;
    public float speed = 5f;
    bool onGround = true;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.rotation * new Vector3(Input.GetAxis(Xaxis) * speed, rb.velocity.y, Input.GetAxis(Yaxis) * speed);

        if (Input.GetKeyDown(jump))
        {
            if (onGround == true)
            {
                rb.AddForce(new Vector3(0, 35, 0), ForceMode.VelocityChange);
                onGround = false;
            }
        }
            onGround = Physics.CheckBox(this.transform.position - new Vector3(0, 1.6f, 0), new Vector3(0.45f, 0.01f, 0.2f), new Quaternion(0, 0, 0, 0), 1 << LayerMask.NameToLayer("Solid"));

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (onGround == true)
            {
                rb.AddForce(new Vector3(0, -1000, 0), ForceMode.Impulse);
            }
        }

    }
}
