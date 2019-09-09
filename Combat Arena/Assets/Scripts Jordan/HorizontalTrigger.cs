using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorizontalTrigger : MonoBehaviour
{
    public Toggle HoriSwitch;
    public static bool Horizontal = false;

    // Horizontal wordt opgehaalt op de checkbox in Settings. als het true is, zet het de game's camera naar horizontal 
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
