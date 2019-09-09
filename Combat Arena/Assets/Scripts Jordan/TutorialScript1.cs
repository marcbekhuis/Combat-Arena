using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialScript1 : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject MenuButton;
    public GameObject NextButton;

    public void TutorialBack()
    {
        if (TutorialScript.text == 6)
        {
            MenuButton.SetActive(false);
            NextButton.SetActive(true);
            text7.SetActive(false);
            TutorialScript.text = 5;
            text6.SetActive(true);
        }
        else if (TutorialScript.text == 5)
        {
            text6.SetActive(false);
            TutorialScript.text = 4;
            text5.SetActive(true);
        }
        else if (TutorialScript.text == 4)
        {
            text5.SetActive(false);
            TutorialScript.text = 4;
            text4.SetActive(true);
        }
        else if (TutorialScript.text == 3)
        {
            text4.SetActive(false);
            TutorialScript.text = 2;
            text3.SetActive(true);
        }
        else if (TutorialScript.text == 2)
        {
            text3.SetActive(false);
            TutorialScript.text = 1;
            text2.SetActive(true);
        }
        else if (TutorialScript.text == 1)
        {
            text2.SetActive(false);
            TutorialScript.text = 0;
            text1.SetActive(true);
        }
        else if (TutorialScript.text == 0)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
