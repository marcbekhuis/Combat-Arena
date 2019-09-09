using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    // Update is called once per frame

    public void LoadScene(string scene)
    {
        // when pressed a button, it will change scene based on what the unity button has been assigned to
        SceneManager.LoadScene(scene);
    }

    public void Quit ()
    {
        // closes the game
        Application.Quit();
    }
}
