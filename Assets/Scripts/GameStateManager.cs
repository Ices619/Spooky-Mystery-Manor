using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    //Set the score up so the system can keep count
    public GameObject prefab;
    public int howMany;
    private int score;


    public int GetScore()
    {
        return score;
    }

    public void SetScore(int s)
    {
        score = s;
    }

    public void adjustScore(int s)
    {
        score += s;
        Debug.Log("Score is " + score);
    }


    // Start is called before the first frame update
    void Start()
    {
        //Makes sure that this object onload isn't destroyed. Meaning the score doesn't reset when loading onto another scene and keeps track
        DontDestroyOnLoad(this.gameObject);

        if (FindObjectsOfType(this.GetType()).Length > 1)
        {
            Destroy(this.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
