using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    //Calls script PlayerHealth and dam as in and audiosource
    public PlayerHealth playerHealth;
    public int damage = 2;
    public GameObject Zombie;
    public AudioSource Hurt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //If collision to player then player takes damage and playerhealth script loses 1
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "")
        {
            Zombie.GetComponent<Animation>().Play("Z_Walk 1");
        }

        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
            Hurt.Play();
        }
    }
}
