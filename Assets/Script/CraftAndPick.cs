using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class CraftAndPick : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject itemTypeNeedle;
    public GameObject itemTypeThread;
    public bool canInteractItem = false;
    public ItemQuest needle;
    public ItemQuest thread;
    public ItemQuest sewkit;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (canInteractItem == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
        {
            if (PlayerStatus.instance.checkItem(needle))
            {
                if (!PlayerStatus.instance.checkItem(thread))
                {
                    PlayerStatus.instance.addItem(thread);
                    itemTypeThread.SetActive(false);
                    PlayerStatus.instance.pickupitemstatus = true;
                    PlayerStatus.instance.HaveThread = true;
                }
            }

            else if (PlayerStatus.instance.checkItem(thread))
            {
                if (!PlayerStatus.instance.checkItem(needle))
                {
                    PlayerStatus.instance.addItem(needle);
                    itemTypeNeedle.SetActive(false);
                    PlayerStatus.instance.pickupitemstatus = true;
                    PlayerStatus.instance.HaveNeedle = true;
                }
            }
        }

        if (PlayerStatus.instance.checkItem(thread) && PlayerStatus.instance.checkItem(needle))
        {
            PlayerStatus.instance.itembag.Clear();
            PlayerStatus.instance.addItem(sewkit);
            PlayerStatus.instance.dollQuestSuccessfully = true;
            Objectives.instance.SetQuest(Objectives.CurrentQuest.Quest6);
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
