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
        cursemovescript.Sensitivity = MouseSensitivity.MouseSens;
       // Debug.Log(MouseSensitivity.MouseSens);
      //  Debug.Log(cursemovescript.Sensitivity);
    }
}
