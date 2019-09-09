using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public string Xaxis = "HorizontalP1";
    public string Yaxis = "VerticalP1";
    [Space]

    public KeyCode jump = KeyCode.Space;
    public KeyCode run = KeyCode.LeftShift;
    [Space]

    public float walkSpeed = 5f;
    public float runSpeed = 10f;
    public AudioSource source;

    Rigidbody rb;
    bool onGround = true;
    float jumpCooldown = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(run))
        {
            rb.velocity = transform.rotation * new Vector3(Input.GetAxis(Xaxis) * runSpeed, rb.velocity.y, Input.GetAxis(Yaxis) * runSpeed);
        }
        else
        {
            rb.velocity = transform.rotation * new Vector3(Input.GetAxis(Xaxis) * walkSpeed, rb.velocity.y, Input.GetAxis(Yaxis) * walkSpeed);
        }

        if (!onGround && Physics.CheckBox(this.transform.position - new Vector3(0, 1.6f, 0), new Vector3(0.45f, 0.01f, 0.2f), new Quaternion(0, 0, 0, 0), 1 << LayerMask.NameToLayer("Solid")))
        {
            onGround = true;
            source.Play();
        }
        if (Input.GetKey(jump) && jumpCooldown <= 0)
        {
            if (onGround)
            {
                rb.AddForce(new Vector3(0, 40, 0), ForceMode.VelocityChange);
                onGround = false;
                jumpCooldown = 0.3f;
            }
        }
        jumpCooldown -= Time.deltaTime;

    }
}
