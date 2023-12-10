using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BZRightJumpTrigger : MonoBehaviour
{

    public GameObject TheZombie;
    public GameObject TheZombie2;


    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        TheZombie.SetActive(true);
        TheZombie2.SetActive(true);

    }


}
