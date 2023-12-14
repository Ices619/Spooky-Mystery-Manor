using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    public GameObject TheGun;
    public GameObject MuzzleFlash;
    public AudioSource GunFire;
    public bool IsFiring = false;
    public float TargetDistance;
    public int DamageAmount = 5;


    //Starts as flash as unactive
    private void Start()
    {
        MuzzleFlash.SetActive(false);
    }

    //if the pistol if fired IEnumerator plays
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (IsFiring == false)
            {
                StartCoroutine(FiringPistol());
            }
        }

    }

    //Plays script below for animation and sound of gun
    IEnumerator FiringPistol()
    {
        IsFiring = true;
        TheGun.GetComponent<Animation>().Play("PistolShot");
        MuzzleFlash.SetActive(true);
        MuzzleFlash.GetComponent<Animation>().Play("MuzzleAnim");
        GunFire.Play();
        yield return new WaitForSeconds(0.5f);
        IsFiring =false;
    }
}
