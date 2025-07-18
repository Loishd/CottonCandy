using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class AreaInteraction : MonoBehaviour
{
    public PlayerStatus isdial;
    public DialogueSystem dialogue;
    public GameObject NPCPanel;
    private Rigidbody2D rb;
    public bool canInteract = false;
    

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
            if (isdial.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
            {
                dialogue.textComponent.text = string.Empty; //reset dialogue
                NPCPanel.SetActive(true); //show dialogue
                dialogue.StartDialogue(); //run the dialogue
                isdial.isDialogue = true;
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
            isdial.isDialogue = false;
        }
        
    }




}
