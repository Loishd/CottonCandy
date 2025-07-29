using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public bool activateBarrier = false;
    public DialogueSystem dialogue;
    public GameObject NPCPanel;
    public GameObject Barrier;
    public GameObject Tony;
    public GameObject Charlie;
    public GameObject TonyPost;
    public GameObject CharliePost;
    public GameObject bar1;
    public GameObject bar2;


    void Start()
    {
        bar1.SetActive(false);
        bar2.SetActive(false);
    }

    
    void Update()
    {
        if (PlayerStatus.instance.sketchFlowerSuccessfully == true) 
        {
            Tony.transform.position = new Vector3(13f, 0f, 0.071f);
            Charlie.transform.position = new Vector3(-13.37f, -20.45f, 0.038f);
            Tony.SetActive(false);
            Charlie.SetActive(false);
            TonyPost.SetActive(true);
            CharliePost.SetActive(true);
            bar1.SetActive(true);
            bar2.SetActive(true);

        }

        if (activateBarrier == true && PlayerStatus.instance.sketchFlowerSuccessfully == false)
        {
            Barrier.SetActive(true);
            if (PlayerStatus.instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
            {
                dialogue.textComponent.text = string.Empty; //reset dialogue
                NPCPanel.SetActive(true); //show dialogue
                dialogue.StartDialogue(); //run the dialogue
                PlayerStatus.instance.isDialogue = true;
                PlayerStatus.instance.triedToExit = true;
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
