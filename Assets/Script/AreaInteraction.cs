using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[Serializable]
public class AreaInteraction : MonoBehaviour
{
    public PlayerStatus playerstatus;
    public DialogueSystem dialogue;
    public GameObject NPCPanel;
    private Rigidbody2D rb;
    [HideInInspector] public bool canInteract = false;
    public ItemQuest axeEnding;
    public ItemQuest flowerStudentEnding;
    public ItemQuest foodStudentEnding;
    public ItemQuest flowerButterEnding;
    public ItemQuest fishnotEnd;
    public ItemQuest flowerSketchEnding;
    public ItemQuest sewkitStudentEnding;
    public ItemQuest dollQuestEnding;
    public ItemQuest notepadEnding;
    
    private void Awake()
    {
            
        
    }

    void Start()
    {
        
    }

    IEnumerator AxeEndingInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("AxeEnding");
    }
    IEnumerator FlowerStudentInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Flower");
    }
    IEnumerator FoodEndingInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("LunchEnding");
    }
    IEnumerator sewkitStudentInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("SewEnding");
    }
    IEnumerator dollEndingInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("DollEnding");
    }

    IEnumerator sketchNotepadEndingInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("NotepadEnding");
    }
    void Update()
    {
        if (canInteract == true && Input.GetKeyDown(KeyCode.E)) //press E to run ts
        {
            if (PlayerStatus.instance.checkItem(axeEnding))
            {
                Debug.Log("Axe Cutscene");
                PlayerPrefs.SetInt("Ending1", 1);
                StartCoroutine(AxeEndingInDelay());
             

            }
            else if (PlayerStatus.instance.checkItem(flowerStudentEnding))
            {
                Debug.Log("FlowerStudent Cutscene");
                PlayerPrefs.SetInt("Ending5", 1);
                StartCoroutine(FlowerStudentInDelay());
            }
            else if (PlayerStatus.instance.checkItem(foodStudentEnding))
            {
                Debug.Log("FoodEnding Cutscene");
                PlayerPrefs.SetInt("Ending9", 1);
                StartCoroutine(FoodEndingInDelay());
            }
            else if (PlayerStatus.instance.checkItem(sewkitStudentEnding))
            {
                Debug.Log("sewkitStudent");
                PlayerPrefs.SetInt("Ending4", 1);
                StartCoroutine(sewkitStudentInDelay());
            }
            else if (PlayerStatus.instance.checkItem(dollQuestEnding))
            {
                Debug.Log("dollEnding");
                PlayerPrefs.SetInt("Ending3", 1);
                StartCoroutine(dollEndingInDelay());
            }
            else if (PlayerStatus.instance.checkItem(notepadEnding))
            {
                Debug.Log("sketchNotepadEnding");
                PlayerPrefs.SetInt("Ending8", 1);
                StartCoroutine(sketchNotepadEndingInDelay());
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
            CharacterImagine.Instance.closeCharacterImage();
        }
        
    }




}
