using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sketchQuest : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool canInteractItem = false;
    public ItemQuest item;

    void Update()
    {
        
            if (canInteractItem == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
            {
                if (PlayerStatus.instance.itembag.Count == 0)
                {
                    if (PlayerStatus.instance.pickupitemstatus == false)
                    {
                        PlayerStatus.instance.addItem(item);
                        PlayerStatus.instance.pickupitemstatus = true;

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

}
