using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    // Update is called once per frame

    public void startGame()
    {
        SceneManager.LoadScene("Marc");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Quit ()
    {
        Application.Quit();
    }
}
