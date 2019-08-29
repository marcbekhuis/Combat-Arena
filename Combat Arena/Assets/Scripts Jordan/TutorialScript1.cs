using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialScript1 : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;

    public void TutorialBack()
    {
        Debug.Log("buttonpressedBack" + TutorialScript.text);
        /*if (text == 2)
        {
            text3.SetActive(false);
            text = 1;
            text2.SetActive(true);
        }*/
        if (TutorialScript.text == 1)
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
