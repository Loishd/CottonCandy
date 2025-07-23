using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentQuest : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool canInteractItem = false;
    public GameObject itemType;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (canInteractItem == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
        {
            if (PlayerStatus.instance.foundSpeaker == false)
            {
                PlayerStatus.instance.foundSpeaker = true;
                itemType.SetActive(true);
                Objectives.instance.SetQuest(Objectives.CurrentQuest.Quest2);
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

        }

    }


}
