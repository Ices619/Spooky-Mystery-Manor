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


}