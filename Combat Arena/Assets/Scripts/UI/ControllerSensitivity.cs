using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerSensitivity : MonoBehaviour
{
    public Slider ControllerSen;

    public static int ControllerSens = 1;

    // Update is called once per frame
    void Update()
    {
        // sets Variable to the value of the controller sensitivity that has been changed inside "Settings" Scene
        ControllerSens = (int)ControllerSen.value;
    }
}
