using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "")
        {
            Zombie.GetComponent<Animation>().Play("Z_Walk 1");
        }

        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
            Zombie.GetComponent<Animation>().Play("Z_Attack 1");
            Hurt.Play();
        }
    }
}
