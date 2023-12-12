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

    //public Renderer PlayerSR;
    //public FirstPersonMovement playerMovement;

    void Start()
    {
        health = MaxHealth;
    }

    // Update is called once per frame
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            //PlayerSR.enabled = false;
            //playerMovement.enabled = false;
            //Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
            FirstPersonController.SetActive(false);
        }
    }
}
