using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpPistol : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionTextPistol;
    public GameObject FakePistol;
    public GameObject RealPistol;
    public GameObject GuideArrow;
    public GameObject ExtraCross;
    public GameObject TheJumpTrigger;
   

    private void Start()
    {
        ExtraCross.SetActive(false);
        ActionTextPistol.GetComponent<Text>().text = "Pick up Pistol";
        ActionDisplay.SetActive(false);
        ActionTextPistol.SetActive(false);
    }
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    private void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ExtraCross.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionTextPistol.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionTextPistol.SetActive(false);
                FakePistol.SetActive(false);
                RealPistol.SetActive(true);
                ExtraCross.SetActive(false);
                GuideArrow.SetActive(false);
                TheJumpTrigger.SetActive(true);
            }
        }
    }

    private void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionTextPistol.SetActive(false); 
    }
}
