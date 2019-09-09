using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialMenuButton : MonoBehaviour
{
    public void MainMenu ()
    {
        // sets the text value back to beginning and returns the player to main menu
        TutorialScript.text = 0;
        SceneManager.LoadScene("Main Menu");
    }
}
