using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{

    public int health = 1000;
    public Text HealthText;
    public GameObject gameover;
    public string player;

    void Start()
    {
        HealthText.text = "Health: " + health;
    }

    public void healthfunction()
    {
        HealthText.text = "Health: " + health;
        
    }
    public void healthlose(int damage)
    {
        health -= damage;
        healthfunction();
        if (health == 0)
        {
            Gameover();
        }
    }

    public void Gameover()
    {
        gameover.SetActive(true);
        gameover.GetComponentInChildren<Text>().text = "Gameover\n" + player + " Won!";
        Cursor.visible = true;
    }
}
