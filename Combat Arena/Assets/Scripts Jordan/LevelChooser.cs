using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChooser : MonoBehaviour
{
    public static int process;

    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject text;

    public GameObject text1;
    public GameObject Forest;
    public GameObject Western;
    public GameObject Level3;
    public GameObject Back;

    private void Start()
    {
        text1.SetActive(false);
        Forest.SetActive(false);
        Western.SetActive(false);
        Level3.SetActive(false);
        Back.SetActive(false);
        process = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (process == 1)
        {
            text1.SetActive(true);
            Forest.SetActive(true);
            Western.SetActive(true);
            Level3.SetActive(true);
            Back.SetActive(true);

            Button1.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(false);
            Button4.SetActive(false);
            text.SetActive(false);
        }
        else
        {
            text1.SetActive(false);
            Forest.SetActive(false);
            Western.SetActive(false);
            Level3.SetActive(false);
            Back.SetActive(false);

            Button1.SetActive(true);
            Button2.SetActive(true);
            Button3.SetActive(true);
            Button4.SetActive(true);
            text.SetActive(true);   
        }
    }

    
}
