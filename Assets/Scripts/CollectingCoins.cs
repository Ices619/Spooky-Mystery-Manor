using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{

    public int coins;
    public AudioSource Ching;
    // Start is called before the first frame update
    void Start()
    {
        
    }

 
    // Increses score by one for each collision the player does
    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Coin")
        {
            Debug.Log("Coin Collected!");
            coins = coins + 1;
            GameObject.Find("GameStateManager").GetComponent<GameStateManager>().adjustScore(1);
            Col.gameObject.SetActive(false);
            Ching.Play();
            
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
