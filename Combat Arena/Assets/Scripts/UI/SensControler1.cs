using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensControler1 : MonoBehaviour
{
    cursormove cursemovescript;
    private void Start()
    {
        cursemovescript = this.GetComponent<cursormove>();
        cursemovescript.Sensitivity = ControllerSensitivity.ControllerSens;
        Destroy(this);
    }
}
