using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialMenuButton : MonoBehaviour
{
    public void MainMenu ()
    {
        TutorialScript.text = 0;
        SceneManager.LoadScene("Main Menu");
    }
}
