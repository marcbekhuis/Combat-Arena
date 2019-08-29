using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public string Xaxis = "HorizontalP1";
    public string Yaxis = "VerticalP1";

    Rigidbody rb;
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.rotation * new Vector3(Input.GetAxis(Xaxis) * 5, 0, Input.GetAxis(Yaxis) * 5);
    }
}
