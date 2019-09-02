using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{

    int health = 1000;
    public Text HealthText;

    void Start()
    {
        HealthText.text = "Health:" + health;
    }

    // Update is called once per frame
    void Update()
    {
        healthfunction();
    }

    public void healthfunction()
    {
        HealthText.text = "Health:" + health;
        
    }
    public void healthloss()
    {
        health -= 100;
        healthfunction();
    }
}
