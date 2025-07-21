using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dollQuest : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool canInteractItem = false;
    public GameObject itemType;
    public ItemQuest requireItem;
    public ItemQuest giveItem;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (canInteractItem == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
        {

            if (PlayerStatus.instance.acceptDollQuest == false)
            {
                PlayerStatus.instance.acceptDollQuest = true;
                itemType.SetActive(true);
            }


            if (PlayerStatus.instance.itembag.Count == 1)
            {
                if (PlayerStatus.instance.checkItem(requireItem) && PlayerStatus.instance.acceptDollQuest == true)
                {
                    PlayerStatus.instance.itembag.RemoveAt(0);
                    PlayerStatus.instance.dollQuestSuccessfully = true;
                    PlayerStatus.instance.pickupitemstatus = false; 
                    

                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) //if player in this area can interact
    {
        if (collision.CompareTag("Player"))
        {
            canInteractItem = true;

        }


    }

    private void OnTriggerExit2D(Collider2D collision) //if player in this area cannot interact
    {
        if (collision.CompareTag("Player"))
        {
            canInteractItem = false;

        }

    }



}
