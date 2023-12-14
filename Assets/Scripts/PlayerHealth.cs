using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int MaxHealth = 10;
    public GameObject FirstPersonController;

    //Health starts the same as MaxHealth
    void Start()
    {
        health = MaxHealth;
    }

    // if health reaches zero then game over screen plays and player controller is disabled
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
            FirstPersonController.SetActive(true);
        }
    }
}
