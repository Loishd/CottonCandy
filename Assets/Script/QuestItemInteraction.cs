using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItemInteraction : MonoBehaviour
{
    public bool canInteractItem = false;
    public GameObject itemType;
    public ItemQuest itemGiver1;
    public ItemQuest itemGiver2;
    public ItemQuest itemNeed;
    public DialogueSystem dialogue;
    public GameObject NPCPanel;

    void Start()
    {
        itemType.SetActive(false);
    }

    
    void Update()
    {
        
        if (canInteractItem == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
        {
            if (PlayerStatus.instance.colinQuestsuccessfully == true)
            {
                Debug.Log("Run the Colin Ending");
                PlayerPrefs.SetInt("Ending2", 1);
            }
            else
            {
                if (!PlayerStatus.instance.checkItem(itemNeed))
                {
                    if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                    {

                        dialogue.textComponent.text = string.Empty; //reset dialogue
                        NPCPanel.SetActive(true); //show dialogue
                        dialogue.StartDialogue(); //run the dialogue
                        PlayerStatus.instance.isDialogue = true;
                    }
                }
            }
        }


        if (PlayerStatus.instance.dollQuestSuccessfully == true)
        {
            if (canInteractItem == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
            {
                if (PlayerStatus.instance.checkItem(itemNeed))
                {
                    if (!PlayerStatus.instance.checkItem(itemGiver2))
                    {
                        PlayerStatus.instance.itembag.Clear();
                        PlayerStatus.instance.addItem(itemGiver2);
                        itemType.SetActive(false);
                        Objectives.instance.SetQuest(Objectives.CurrentQuest.Quest7);
                    }
                }
                else
                {
                    if (!PlayerStatus.instance.checkItem(itemNeed))
                    {
                        if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                        {

                            dialogue.textComponent.text = string.Empty; //reset dialogue
                            NPCPanel.SetActive(true); //show dialogue
                            dialogue.StartDialogue(); //run the dialogue
                            PlayerStatus.instance.isDialogue = true;
                        }
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
            NPCPanel.SetActive(false);
            dialogue.textComponent.text = string.Empty;
            PlayerStatus.instance.isDialogue = false;
            CharacterImagine.Instance.closeCharacterImage();
        }
        
    }


}

