using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorizontalTrigger : MonoBehaviour
{
    public Toggle HoriSwitch;
    public static bool Horizontal = false;

    private void Update()
    {
        Debug.Log(Horizontal);
    }

    public void Toggled ()
    {
        if (Horizontal == false)
        {
            Horizontal = true;
        }
        else if (Horizontal == true)
        {
            Horizontal = false;
        }
    }
}
