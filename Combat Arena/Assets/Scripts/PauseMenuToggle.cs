using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuToggle : MonoBehaviour
{
    public KeyCode input = KeyCode.Escape;
    public GameObject canvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(input))
        {
            if (canvas.activeSelf)
            {
                canvas.SetActive(false);
                Cursor.visible = false;
            }
            else
            {
                canvas.SetActive(true);
                Cursor.visible = true;
            }
        }
    }
}
