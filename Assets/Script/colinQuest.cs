using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colinQuest : MonoBehaviour
{
    public DialogueSystem dialogue1;
    public GameObject NPCPanel1;
    public DialogueSystem dialogue2;
    public GameObject NPCPanel2;
    public DialogueSystem dialogue3;
    public GameObject NPCPanel3;
    private Rigidbody2D rb;
    public bool canInteractItem = false;

    void Start()
    {

    }


    void Update()
    {
        if (canInteractItem == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
        {
            if (PlayerStatus.instance.foundSpeaker == true && PlayerStatus.instance.colinQuestsuccessfully == false)
            {
                if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {

                    dialogue2.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel2.SetActive(true); //show dialogue
                    dialogue2.StartDialogue(); //run the dialogue
                    PlayerStatus.instance.isDialogue = true;
                }

                if (PlayerStatus.instance.acceptColinQuest == false)
                {
                    PlayerStatus.instance.acceptColinQuest = true;
                    Objectives.instance.SetQuest(Objectives.CurrentQuest.Quest3);
                }
            }
            else if (PlayerStatus.instance.colinQuestsuccessfully == true)
            {
                if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {

                    dialogue3.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel3.SetActive(true); //show dialogue
                    dialogue3.StartDialogue(); //run the dialogue
                    PlayerStatus.instance.isDialogue = true;
                }
            }
            else
            {
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

            PlayerStatus.instance.isDialogue = false;
            CharacterImagine.Instance.closeCharacterImage();    
        }

    }

}
