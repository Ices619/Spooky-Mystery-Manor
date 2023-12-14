using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAi : MonoBehaviour
{
    public GameObject Target;
    public float speed = 0.1f;
    public 


    void Start()
    {
        
    }

    // Follows the object inputted in inspector
    void Update()
    {
        transform.LookAt(Target.gameObject.transform);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

}
