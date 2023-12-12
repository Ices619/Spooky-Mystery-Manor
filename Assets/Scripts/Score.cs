using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //Set the variable to text for scoreText and calls GameStateManager gsm in this script
    public Text scoreText;
    private GameStateManager gsm;
    //Start is called before the first frame update
    void Start()
    {
        //finds the GameStateManager Object in unity
        gsm = GameObject.Find("GameStateManager").GetComponent<GameStateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Displays the score
        scoreText.text = "Score: " + gsm.GetScore();
    }
}
