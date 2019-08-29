using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialScript : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public static int text;

    // Start is called before the first frame update
    void Awake()
    {
        text2.SetActive(false);
        text = 0;
    }

    private void Update()
    {
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
        /*else if (text == 1)
        {
            text2.SetActive(false);
            text = 2;
            text3.SetActive(true);
        }*/
    }
}
