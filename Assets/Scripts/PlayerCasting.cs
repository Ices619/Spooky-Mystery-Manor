using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    //float objects on screen from distance
    public static float DistanceFromTarget;
    public float ToTarget;
    void Update()
    {
        //Raycast hit distance will show whatever variable inputted
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            ToTarget = Hit.distance;
            DistanceFromTarget = ToTarget;
            
        }
    }
}
