using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensControler : MonoBehaviour
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
        // When the game plays, it sets the Sensitivity of the P1 Camera to the value of MouseSens
        cursemovescript.Sensitivity = MouseSensitivity.MouseSens;
    }
}
