using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public string Xaxis = "HorizontalP1";
    public string Yaxis = "VerticalP1";
    public Text coords;

    int mode = 0;

    Rigidbody rb;
    public float speed = 5f;
    bool onGround = true;


    // Start is called before the first frame update
    void Start()
    {
        coords.gameObject.SetActive(false);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.rotation * new Vector3(Input.GetAxis(Xaxis) * 5, 0, Input.GetAxis(Yaxis) * 5) * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onGround == true)
            {
                rb.AddForce(new Vector3(0, 2500, 0), ForceMode.Impulse);
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

    void FixedUpdate()
    {
        if (mode == 0)
        {
            coords.text = "coords:" + GameObject.Find("Parent Player").transform.position;


            mode = 1;
        }
        else if (mode == 1)
        {
            coords.text = " ";

            mode = 0;
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            coords.gameObject.SetActive(true);

        }
    }
}
