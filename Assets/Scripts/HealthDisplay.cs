using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    //Health is int
    public int health;
    public int maxHealth;
    //Sprite images for HP
    public Sprite emptyHeart;
    public Sprite fullHeart;
    public Image[] hearts;

    //Call script PlayerHealth
    public PlayerHealth playerHealth;

    void Start()
    {

    }

    // Updates on health display
    void Update()
    {

        health = playerHealth.health;
        maxHealth = playerHealth.MaxHealth;
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if(i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled=false;
            }
        }
    }
}
