using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    public int iteminter { get; private set; }

    public PlayerStatus itemPicker;
    public PlayerStatus itemprogresser;
    public GameObject itemType;
    private Rigidbody2D rb;
    public bool canInteractItem = false;
    public int ItemValue;
    
    
    private void Awake()
    {
        
    }

    void Start()
    {
        
        itemType.SetActive(true);
        
        
    }


    void Update()
    {
        
        if (canInteractItem == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
        {
            
            if (itemPicker.pickupitemstatus == false)
            {
                if (ItemValue == 10)
                {
                    Debug.Log("GoodItem");
                }
                else if (ItemValue == 1)
                {
                    Debug.Log("BadItem");
                }
                else
                {
                    Debug.Log("Neutral");
                }
                itemType.SetActive(false);
                itemPicker.pickupitemstatus = true;
                itemprogresser.progressvalue += ItemValue;
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





