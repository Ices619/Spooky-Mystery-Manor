using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public GameObject Target;
    public float speed = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Target.transform.position);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
