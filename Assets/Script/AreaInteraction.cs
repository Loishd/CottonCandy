using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class AreaInteraction : MonoBehaviour
{
    private static AreaInteraction _instance;
    public static AreaInteraction Instance { get { return _instance; } }
    private Rigidbody2D rb;
    public bool canInteract = false;
    public GameObject NPCPanel;

    private void Awake()
    {
            _instance = this;
        
    }

    void Start()
    {
    }

    
    void Update()
    {
        



        if (canInteract == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
        {
            if (DialogueSystem.Instance.isDialogue == false) //player cannot re-open the dialogue while dialogue-ing
            {
                DialogueSystem.Instance.textComponent.text = string.Empty; //reset dialogue
                NPCPanel.SetActive(true); //show dialogue
                DialogueSystem.Instance.StartDialogue(); //run the dialogue
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
            DialogueSystem.Instance.textComponent.text = string.Empty;
            DialogueSystem.Instance.isDialogue = false;
        }
        
    }




}
