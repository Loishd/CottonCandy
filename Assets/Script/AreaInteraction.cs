using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AreaInteraction : MonoBehaviour
{
    public DialogueSystem dialogue;
    

    private Rigidbody2D rb;
    public bool canInteract = false; 


    void Start()
    {
    }

    
    void Update()
    {
        if (canInteract == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
        {
            Debug.Log("E pressed");
            DialogueSystem.Instance.textComponent.text = string.Empty;
            DialogueSystem.Instance.gameObject.SetActive(true);
            DialogueSystem.Instance.StartDialogue();
            
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
        }
        
    }




}
