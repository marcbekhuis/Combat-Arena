using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensControler : MonoBehaviour
{
    cursormove cursemovescript;
    private void Start()
    {
        cursemovescript = this.GetComponent<cursormove>();
        cursemovescript.Sensitivity = MouseSensitivity.MouseSens;
        Destroy(this);
    }
}
