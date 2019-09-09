using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialScript : MonoBehaviour
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
    public static int text;

    // Start is called before the first frame update
    void Awake()
    {
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        text5.SetActive(false);
        text6.SetActive(false);
        text7.SetActive(false);
        MenuButton.SetActive(false);
    }

    private void Update()
    {
        if (text == 2)
        {
            NextButton.SetActive(true);
            MenuButton.SetActive(false);
        }
        Debug.Log(text);
    }

    public void TutorialNext ()
    {
        Debug.Log("buttonpressed " + text);
        if (text == 0)
        {
            text1.SetActive(false);
            text += 1;
            text2.SetActive(true);
        }
        else if (text == 1)
        {
            text2.SetActive(false);
            text = 2;
            text3.SetActive(true);
        }
        else if (text == 2)
        {
            text3.SetActive(false);
            text = 3;
            text4.SetActive(true);   
        }
        else if (text == 3)
        {
            text4.SetActive(false);
            text = 4;
            text5.SetActive(true);
        }
        else if (text == 4)
        {
            text5.SetActive(false);
            text = 5;
            text6.SetActive(true);
        }
        else if (text == 5)
        {
            text6.SetActive(false);
            text = 6;
            text7.SetActive(true);
            NextButton.SetActive(false);
            MenuButton.SetActive(true);
        }
    }
}
