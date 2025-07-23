using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class steakQuest : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool canInteractItem = false;
    public GameObject itemType;
    public ItemQuest requireItem;
    public ItemQuest giveItem;
    public DialogueSystem dialogue1;
    public GameObject NPCPanel1;
    public DialogueSystem dialogue2;
    public GameObject NPCPanel2;
    public DialogueSystem dialogue3;
    public GameObject NPCPanel3;
    public DialogueSystem dialogue4;
    public GameObject NPCPanel4;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (canInteractItem == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
        {
            if (PlayerStatus.instance.checkItem(requireItem) && PlayerStatus.instance.acceptSteakQuest == false && PlayerStatus.instance.acceptColinQuest == true)
            {
                PlayerStatus.instance.itembag.RemoveAt(0);
                Debug.Log("Give Steak a fish for Colin Quest");
                PlayerStatus.instance.colinQuestsuccessfully = true;
                Objectives.instance.SetQuest(Objectives.CurrentQuest.Quest4);
                if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {

                    dialogue3.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel3.SetActive(true); //show dialogue
                    dialogue3.StartDialogue(); //run the dialogue
                    PlayerStatus.instance.isDialogue = true;
                }
            }

            else if (PlayerStatus.instance.itembag.Count == 1)
            {
                if (PlayerStatus.instance.checkItem(requireItem) && PlayerStatus.instance.acceptSteakQuest == true && PlayerStatus.instance.acceptColinQuest == false)
                {
                    PlayerStatus.instance.itembag.RemoveAt(0);
                    PlayerStatus.instance.steakQuestSuccessfully = true;
                    PlayerStatus.instance.pickupitemstatus = false;
                    itemType.SetActive(true);
                    Objectives.instance.SetQuest(Objectives.CurrentQuest.Quest11);
                    if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                    {

                        dialogue2.textComponent.text = string.Empty; //reset dialogue
                        NPCPanel2.SetActive(true); //show dialogue
                        dialogue2.StartDialogue(); //run the dialogue
                        PlayerStatus.instance.isDialogue = true;
                    }
                }
            }

            if (PlayerStatus.instance.checkItem(requireItem) && PlayerStatus.instance.acceptSteakQuest == false)
            {
                PlayerStatus.instance.itembag.RemoveAt(0);
                Debug.Log("Give Steak a fish for free");
                PlayerStatus.instance.pickupitemstatus = false;

                if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {

                    dialogue4.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel4.SetActive(true); //show dialogue
                    dialogue4.StartDialogue(); //run the dialogue
                    PlayerStatus.instance.isDialogue = true;
                }
            }

            else if (PlayerStatus.instance.acceptSteakQuest == false)
            {
                if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {

                    dialogue1.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel1.SetActive(true); //show dialogue
                    dialogue1.StartDialogue(); //run the dialogue
                    PlayerStatus.instance.isDialogue = true;
                }
                if (PlayerStatus.instance.acceptColinQuest == false)
                {
                    PlayerStatus.instance.acceptSteakQuest = true;
                    Objectives.instance.SetQuest(Objectives.CurrentQuest.Quest10);
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
            NPCPanel1.SetActive(false);
            dialogue1.textComponent.text = string.Empty;

            NPCPanel2.SetActive(false);
            dialogue2.textComponent.text = string.Empty;

            NPCPanel3.SetActive(false);
            dialogue3.textComponent.text = string.Empty;

            NPCPanel4.SetActive(false);
            dialogue4.textComponent.text = string.Empty;

            PlayerStatus.instance.isDialogue = false;
        }

    }



}
