using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItemInteraction : MonoBehaviour
{
    public bool canInteractItem = false;
    public GameObject itemType;
    public ItemQuest itemGiver1;
    public ItemQuest itemGiver2;

    void Start()
    {
        itemType.SetActive(false);
    }

    
    void Update()
    {
        if (PlayerStatus.instance.dollQuestSuccessfully == true)
        {
            if (canInteractItem == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
            {
                if (!PlayerStatus.instance.checkItem(itemGiver2))
                {
                    if (PlayerStatus.instance.pickupitemstatus == false)
                    {
                        PlayerStatus.instance.addItem(itemGiver2);
                        itemType.SetActive(false);
                        PlayerStatus.instance.pickupitemstatus = true;

                    }
                }
            }
        }

        if (PlayerStatus.instance.steakQuestSuccessfully == true)
        {
            if (canInteractItem == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
            {
                if (!PlayerStatus.instance.checkItem(itemGiver1))
                {
                    if (PlayerStatus.instance.pickupitemstatus == false)
                    {
                        PlayerStatus.instance.addItem(itemGiver1);
                        itemType.SetActive(false);
                        PlayerStatus.instance.pickupitemstatus = true;

                    }
                }
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision) //if player in this area can interact
    {
        if (PlayerStatus.instance.steakQuestSuccessfully == true || PlayerStatus.instance.dollQuestSuccessfully == true)
        {
            if (collision.CompareTag("Player"))
            {
                canInteractItem = true;

            }
        }

    }

    private void OnTriggerExit2D(Collider2D collision) //if player in this area cannot interact
    {

        if (PlayerStatus.instance.steakQuestSuccessfully == true || PlayerStatus.instance.dollQuestSuccessfully == true)
        {
            if (collision.CompareTag("Player"))
            {
                canInteractItem = false;

            }
        }

    }


}

