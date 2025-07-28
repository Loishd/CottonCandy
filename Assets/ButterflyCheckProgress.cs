using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyCheckProgress : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool canInteract = false;

    public DialogueSystem dialogue1;
    public GameObject NPCPanel1;
    public DialogueSystem dialogue2;
    public GameObject NPCPanel2;
    public DialogueSystem dialogue3;
    public GameObject NPCPanel3;
    public DialogueSystem dialogue4;
    public GameObject NPCPanel4;
    public DialogueSystem dialogue5;
    public GameObject NPCPanel5;
    public DialogueSystem dialogue6;
    public GameObject NPCPanel6;
    public DialogueSystem dialogue7;
    public GameObject NPCPanel7;
    public DialogueSystem dialogue8;
    public GameObject NPCPanel8;
    public DialogueSystem dialogue9;
    public GameObject NPCPanel9;
    public DialogueSystem dialogue10;
    public GameObject NPCPanel10;

    public ItemQuest itemDoll;
    public ItemQuest itemAxe;
    public ItemQuest itemNotebook;
    public ItemQuest itemFish;
    public ItemQuest itemFlower;

    void Start()
    {
        
    }


    void Update()
    {
        if (canInteract == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
        {
            if (PlayerStatus.instance.acceptDollQuest == true)
            {
                if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {
                    dialogue2.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel2.SetActive(true); //show dialogue
                    dialogue2.StartDialogue(); //run the dialogue
                    PlayerStatus.instance.isDialogue = true;
                }
            }
            else if (PlayerStatus.instance.checkItem(itemDoll))
            {
                if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {
                    dialogue3.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel3.SetActive(true); //show dialogue
                    dialogue3.StartDialogue(); //run the dialogue
                    PlayerStatus.instance.isDialogue = true;
                }
            }

            else if (PlayerStatus.instance.checkItem(itemAxe))
            {
                if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {
                    dialogue4.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel4.SetActive(true); //show dialogue
                    dialogue4.StartDialogue(); //run the dialogue
                    PlayerStatus.instance.isDialogue = true;
                }
            }

            else if (PlayerStatus.instance.foundSpeaker == true && PlayerStatus.instance.acceptColinQuest == false)
            {
                if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {
                    dialogue5.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel5.SetActive(true); //show dialogue
                    dialogue5.StartDialogue(); //run the dialogue
                    PlayerStatus.instance.isDialogue = true;
                }
            }

            else if (PlayerStatus.instance.acceptColinQuest == true && PlayerStatus.instance.colinQuestsuccessfully == false)
            {
                if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {
                    dialogue6.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel6.SetActive(true); //show dialogue
                    dialogue6.StartDialogue(); //run the dialogue
                    PlayerStatus.instance.isDialogue = true;
                }
            }

            else if (PlayerStatus.instance.colinQuestsuccessfully == true)
            {
                if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {
                    dialogue7.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel7.SetActive(true); //show dialogue
                    dialogue7.StartDialogue(); //run the dialogue
                    PlayerStatus.instance.isDialogue = true;
                }
            }

            else if (PlayerStatus.instance.triedToExit == true)
            {
                if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {
                    dialogue8.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel8.SetActive(true); //show dialogue
                    dialogue8.StartDialogue(); //run the dialogue
                    PlayerStatus.instance.isDialogue = true;
                }
            }

            else if (PlayerStatus.instance.checkItem(itemNotebook))
            {
                if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {
                    dialogue9.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel9.SetActive(true); //show dialogue
                    dialogue9.StartDialogue(); //run the dialogue
                    PlayerStatus.instance.isDialogue = true;
                }
            }

            else if (PlayerStatus.instance.checkItem(itemNotebook))
            {
                if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {
                    dialogue9.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel9.SetActive(true); //show dialogue
                    dialogue9.StartDialogue(); //run the dialogue
                    PlayerStatus.instance.isDialogue = true;
                }
            }

            else if (PlayerStatus.instance.checkItem(itemFish))
            {
                if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {
                    dialogue10.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel10.SetActive(true); //show dialogue
                    dialogue10.StartDialogue(); //run the dialogue
                    PlayerStatus.instance.isDialogue = true;
                }
            }

            else if (PlayerStatus.instance.checkItem(itemFlower))
            {
                Debug.Log("Insert Butterfly Cutscene Here");
                PlayerPrefs.SetInt("Ending6", 1);
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
            canInteract = true;

        }


    }

    private void OnTriggerExit2D(Collider2D collision) //if player in this area cannot interact
    {
        if (collision.CompareTag("Player"))
        {
            canInteract = false;

            NPCPanel1.SetActive(false);
            dialogue1.textComponent.text = string.Empty;

            NPCPanel2.SetActive(false);
            dialogue2.textComponent.text = string.Empty;

            NPCPanel3.SetActive(false);
            dialogue3.textComponent.text = string.Empty;

            NPCPanel4.SetActive(false);
            dialogue4.textComponent.text = string.Empty;

            dialogue5.textComponent.text = string.Empty;
            NPCPanel5.SetActive(false);
            dialogue6.textComponent.text = string.Empty;
            NPCPanel6.SetActive(false);
            dialogue7.textComponent.text = string.Empty;
            NPCPanel7.SetActive(false);
            dialogue8.textComponent.text = string.Empty;
            NPCPanel8.SetActive(false);
            dialogue9.textComponent.text = string.Empty;
            NPCPanel9.SetActive(false);
            dialogue10.textComponent.text = string.Empty;
            NPCPanel10.SetActive(false);

            PlayerStatus.instance.isDialogue = false;
            CharacterImagine.Instance.closeCharacterImage();
        }

    }
}
