using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryDialogue : MonoBehaviour
{
    public DialogueSystem dialogue1;
    public GameObject Panel1;
    public DialogueSystem dialogue2;
    public GameObject Panel2;
    void Start()
    {
        if (PlayerPrefs.GetInt("RetryBefore") == 1)
        {
            PlayerStatus.instance.loopDialogueB = true;
            dialogue1.textComponent.text = string.Empty; //reset dialogue
            Panel1.SetActive(true); //show dialogue
            dialogue1.StartDialogue(); //run the dialogue
            PlayerStatus.instance.isDialogue = true;
            PlayerPrefs.SetInt("RetryBefore", 0);
        }
        else
        {
            dialogue2.textComponent.text = string.Empty; //reset dialogue
            Panel2.SetActive(true); //show dialogue
            dialogue2.StartDialogue(); //run the dialogue
            PlayerStatus.instance.isDialogue = true;
            PlayerPrefs.SetInt("RetryBefore", 0);
        }
    }

    
    void Update()
    {
        
    }
}
