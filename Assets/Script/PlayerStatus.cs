using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public bool isDialogue;
    public bool pickupitemstatus;
    public bool HaveAxe;
    public bool HaveNeedle;
    void Start()
    {
        pickupitemstatus = false;
        HaveAxe = false;
        HaveNeedle = false;
    }

    
    void Update()
    {
        
    }

    /*if (isDialogue == true)
        {
            PlayerControl.Instance.speed = 0;

        }
        else if (isDialogue == false)
        {
            PlayerControl.Instance.speed = 5;
            Debug.Log("Set Speed to Normal");
        }*/
}
