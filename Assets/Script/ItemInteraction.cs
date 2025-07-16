using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    public GameObject itemType;
    private Rigidbody2D rb;
    public bool canInteractItem = false;
    
    public int Value;
    

    void Start()
    {
        itemType.SetActive(true);
    }


    void Update()
    {
            if (canInteractItem == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
            { 
                if (ItemChecker.Instance.pickedUpItem == false) {
                {
                    itemType.SetActive(false);

                    if (Value == 10)
                    {
                        Debug.Log("Good Item!!");
                    }
                    else if (Value == 1)
                    {
                        Debug.Log("Bad Item");
                    }
                    else
                    {
                        Debug.Log("Neutral");
                    }
                    ItemChecker.Instance.pickedUpItem = true;
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
            
        }

    }

    private void GainValue(int GoodieValue)
    {
        Value = gameObject.GetComponent<ItemChecker>().ItemValue;
    }



}

