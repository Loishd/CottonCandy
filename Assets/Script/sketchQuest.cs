using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sketchQuest : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool canInteractItem = false;
    public ItemQuest item;
    public ItemQuest flower;
    public DialogueSystem dialogue1;
    public GameObject NPCPanel1;
    public DialogueSystem dialogue2;
    public GameObject NPCPanel2;
    public DialogueSystem dialogue3;
    public GameObject NPCPanel3;

    void Update()
    {
        
            if (canInteractItem == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
            {
                if (PlayerStatus.instance.checkItem(flower))
                {
                    if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                    {

                        dialogue3.textComponent.text = string.Empty; //reset dialogue
                        NPCPanel3.SetActive(true); //show dialogue
                        dialogue3.StartDialogue(); //run the dialogue
                        PlayerStatus.instance.isDialogue = true;
                    }
                    Debug.Log("Quit Job Ending");
                    Objectives.instance.SetQuest(Objectives.CurrentQuest.Quest9);
                }

                if (PlayerStatus.instance.checkItem(item))
                {
                    if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                    {

                        dialogue2.textComponent.text = string.Empty; //reset dialogue
                        NPCPanel2.SetActive(true); //show dialogue
                        dialogue2.StartDialogue(); //run the dialogue
                        PlayerStatus.instance.isDialogue = true;
                    }
            
                }

                else if (PlayerStatus.instance.itembag.Count == 0)
                {
                    if (PlayerStatus.instance.pickupitemstatus == false)
                    {
                        PlayerStatus.instance.addItem(item);
                        PlayerStatus.instance.pickupitemstatus = true;

                        if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                        {

                            dialogue1.textComponent.text = string.Empty; //reset dialogue
                            NPCPanel1.SetActive(true); //show dialogue
                            dialogue1.StartDialogue(); //run the dialogue   
                            PlayerStatus.instance.isDialogue = true;
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
            NPCPanel1.SetActive(false);
            dialogue1.textComponent.text = string.Empty;
            NPCPanel2.SetActive(false);
            dialogue2.textComponent.text = string.Empty;
            NPCPanel3.SetActive(false);
            dialogue3.textComponent.text = string.Empty;

            PlayerStatus.instance.isDialogue = false;
        }

    }

}
