using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensControler1 : MonoBehaviour
{
    cursormove cursemovescript;
    private void Start()
    {
        cursemovescript = this.GetComponent<cursormove>();
        cursemovescript.Sensitivity = 1;
    }
    // Update is called once per frame
    void Update()
    {
        cursemovescript.Sensitivity = ControllerSensitivity.ControllerSens;
        Debug.Log(ControllerSensitivity.ControllerSens);
        Debug.Log(cursemovescript.Sensitivity);
    }
}
