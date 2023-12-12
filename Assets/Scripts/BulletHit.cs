using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
    public Rigidbody r;
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {


        //These are the GameObjects with these certain tags will be destroyed and add a point to the score system
        if (col.gameObject.tag == "Zombie")
        {
            Debug.Log("Collision");
            Destroy(col.gameObject);
            GameObject.Find("GameStateManager").GetComponent<GameStateManager>().adjustScore(1);
            Destroy(this.gameObject);
        }
        
    }   
       
    
}

