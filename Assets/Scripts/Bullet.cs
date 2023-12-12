using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform FirePlace;
    public float BulletForce;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            fire();
        }

    }

    void fire()
    {
        GameObject Bullet = Instantiate(BulletPrefab, FirePlace.position, FirePlace.rotation);
        Rigidbody rb = Bullet.GetComponent<Rigidbody>();
        rb.AddForce(FirePlace.forward * BulletForce, ForceMode.Impulse);
        Destroy(Bullet, 3f);


    }

    private void OnCollisionEnter(Collision collision)
    {


        //These are the GameObjects with these certain tags will be destroyed and add a point to the score system
        if (collision.gameObject.tag == "Zombie")
        {
            Debug.Log("Collision");
            Destroy(collision.gameObject);
            GameObject.Find("GameStateManager").GetComponent<GameStateManager>().adjustScore(1);
            Destroy(this.gameObject);
        }

    }
}