using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
public class fishInteraction : MonoBehaviour
{
    public PlayerStatus itemPicker;
    private Rigidbody2D rb;
    public bool canInteractItem = false;
    public ItemQuest itf;
    public PlayableDirector FishJumpScare;
    
    void Start()
    {

    }
    IEnumerator FishingDelay()
    {

        /*MainMenu.instance.CutScene_FadeIn();*/
        yield return new WaitForSeconds(0.1f);
        FishJumpScare.Play();

    }
    public void FishJumpScare01()
    {
        StartCoroutine(FishingDelay());
        
        print("1");
    }
    

    // Update is called once per frame
    void Update()
    {
        if (canInteractItem == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
        {
            if (!PlayerStatus.instance.checkItem(itf))
            {
                if (itemPicker.pickupitemstatus == false)
                {
                    FishJumpScare01();
                    //[                                ]//////////// ADD FISHING CUTSCENE HERE
                    PlayerStatus.instance.addItem(itf);
                    itemPicker.pickupitemstatus = true;
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
