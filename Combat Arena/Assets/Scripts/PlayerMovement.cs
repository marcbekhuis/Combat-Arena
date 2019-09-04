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
    float jumpCooldown = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.rotation * new Vector3(Input.GetAxis(Xaxis) * speed, rb.velocity.y, Input.GetAxis(Yaxis) * speed);

        if (Input.GetKey(jump) && jumpCooldown <= 0)
        {
            if (onGround == true)
            {
                rb.AddForce(new Vector3(0, 40, 0), ForceMode.VelocityChange);
                onGround = false;
                jumpCooldown = 0.3f;
            }
        }
        onGround = Physics.CheckBox(this.transform.position - new Vector3(0, 1.6f, 0), new Vector3(0.45f, 0.01f, 0.2f), new Quaternion(0, 0, 0, 0), 1 << LayerMask.NameToLayer("Solid"));
        jumpCooldown -= Time.deltaTime;
    }
}
