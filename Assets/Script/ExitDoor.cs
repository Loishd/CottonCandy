using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public bool activateBarrier = false;
    public DialogueSystem dialogue;
    public GameObject NPCPanel;
    public GameObject Barrier;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (activateBarrier == true && PlayerStatus.instance.sketchFlowerSuccessfully == false)
        {
            Barrier.SetActive(true);
            if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
            {

                dialogue.textComponent.text = string.Empty; //reset dialogue
                NPCPanel.SetActive(true); //show dialogue
                dialogue.StartDialogue(); //run the dialogue
                PlayerStatus.instance.isDialogue = true;
            }
        }
        else
        {
            Barrier.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) //if player in this area can interact
    {
        if (collision.CompareTag("Player"))
        {
            activateBarrier = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision) //if player in this area cannot interact
    {
        if (collision.CompareTag("Player"))
        {
            activateBarrier = false;
           
        }

    }
}
