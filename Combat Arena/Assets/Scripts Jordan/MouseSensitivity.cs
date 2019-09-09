using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseSensitivity : MonoBehaviour
{
    public Slider MouseSen;

    public static int MouseSens = 1;

    // Update is called once per frame
    void Update()
    {
        // sets Variable to the value of the mouse sensitivity that has been changed inside "Settings" Scene
        MouseSens = (int)MouseSen.value;
    }
}
