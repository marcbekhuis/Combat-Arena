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
        SceneManager.LoadScene(scene);
    }

    public void Quit ()
    {
        Application.Quit();
    }
}
