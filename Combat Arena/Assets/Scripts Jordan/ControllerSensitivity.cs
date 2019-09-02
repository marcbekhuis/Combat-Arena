using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerSensitivity : MonoBehaviour
{
    public Slider ControllerSen;

    public static int ControllerSens;

    // Update is called once per frame
    void Update()
    {
        ControllerSens = (int)ControllerSen.value;
        Debug.Log(ControllerSens);
    }
}
