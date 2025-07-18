using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public bool isDialogue;
    public bool pickupitemstatus;
    public int progressvalue;
    void Start()
    {
        pickupitemstatus = false;
        progressvalue = 0;
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
