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
    public static bool gameEnd = false;

    void Start()
    {
        // sets the text on start
        healthfunction();
        gameEnd = false;
    }

    // Updates the text to show the new health
    public void healthfunction()
    {
        HealthText.text = "Health: " + health;
    }

    // removes the wanted health and check if its still above 0 or should show gameove canvas
    public void healthlose(int damage)
    {
        health = Mathf.Clamp(health - damage, 0, 1000);
        healthfunction();
        if (health <= 0)
        {
            Gameover();
        }
    }

    // shows the gameove canvas
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

    // heals the wanted amount
    public void Heal(int regen)
    {
        health = Mathf.Clamp(health + regen,0,1000);
        healthfunction();
    }
}
