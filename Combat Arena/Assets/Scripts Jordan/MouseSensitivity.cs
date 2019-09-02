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
        MouseSens = (int)MouseSen.value;
        Debug.Log(MouseSens);
    }
}
