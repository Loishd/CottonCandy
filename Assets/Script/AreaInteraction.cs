using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.UI;
using UnityEngine.UI;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class AreaInteraction : MonoBehaviour
{
    public PlayerStatus playerstatus;
    public DialogueSystem dialogue;
    public GameObject NPCPanel;
    private Rigidbody2D rb;
    [HideInInspector] public bool canInteract = false;
    public ItemQuest axeEnding;
    public ItemQuest flowerStudentEnding;
    public ItemQuest flowerButterEnding;
    public ItemQuest fishnotEnd;



    private void Awake()
    {
            
        
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        if (canInteract == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
        {
            if (PlayerStatus.instance.checkItem(axeEnding))
            {
                Debug.Log("Axe Cutscene");
            }
            else if (PlayerStatus.instance.checkItem(flowerStudentEnding))
            {
                Debug.Log("FlowerStudent Cutscene");
            }
            else if (PlayerStatus.instance.checkItem(flowerButterEnding))
            {
                Debug.Log("FlowerButterfly Cutscene");
            }
            else if (PlayerStatus.instance.checkItem(fishnotEnd)) // fishnotEnd && SteakQuest == true
            {
                Debug.Log("FishEnding Cutscene");
            }
            else if (PlayerStatus.instance.checkItemAndRemove(fishnotEnd)) 
            {
                Debug.Log("Give Steak a fish for free");
                playerstatus.pickupitemstatus = false;
            }
            
            else
            {

                if (playerstatus.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
                {
                    
                    dialogue.textComponent.text = string.Empty; //reset dialogue
                    NPCPanel.SetActive(true); //show dialogue
                    dialogue.StartDialogue(); //run the dialogue
                    playerstatus.isDialogue = true;
                    
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
            NPCPanel.SetActive(false); //same as void upd
            dialogue.textComponent.text = string.Empty;
            playerstatus.isDialogue = false;
        }
        
    }




}
