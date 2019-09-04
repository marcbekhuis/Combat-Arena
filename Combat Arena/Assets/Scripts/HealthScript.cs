﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{

    public int health = 1000;
    public Text HealthText;
    public GameObject gameover;
    public string player;
    static bool gameEnd = false;

    void Start()
    {
        HealthText.text = "Health: " + health;
        gameEnd = false;
    }

    public void healthfunction()
    {
        HealthText.text = "Health: " + health;
        
    }
    public void healthlose(int damage)
    {
        health -= damage;
        healthfunction();
        if (health <= 0)
        {
            Gameover();
        }
    }

    public void Gameover()
    {
        if (!gameEnd)
        {
            gameover.SetActive(true);
            gameover.GetComponentInChildren<Text>().text = "Gameover\n" + player + " Won!";
            Cursor.visible = true;
            gameEnd = true;
        }
    }
}
