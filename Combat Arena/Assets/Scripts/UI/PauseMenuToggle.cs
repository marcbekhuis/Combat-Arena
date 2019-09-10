using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuToggle : MonoBehaviour
{
    public KeyCode input = KeyCode.Escape;
    public GameObject canvas;
    public static bool paused;

    private void Start()
    {
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!HealthScript.gameEnd)
        {
            if (Input.GetKeyDown(input))
            {
                if (canvas.activeSelf)
                {
                    canvas.SetActive(false);
                    Cursor.visible = false;
                    paused = false;
                }
                else
                {
                    canvas.SetActive(true);
                    Cursor.visible = true;
                    paused = true;
                }
            }
        }
    }
}
