using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FadeAwayScript : MonoBehaviour
{

    public float fadeTime;
    private TextMeshProUGUI fadeAwayText;

    void Start()
    {
        fadeAwayText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeTime > 0)
        {
            fadeTime -= Time.deltaTime;
            fadeAwayText.color = new Color(fadeAwayText.color.r, fadeAwayText.color.g, fadeAwayText.color.b, fadeTime);
        }
    }
}
