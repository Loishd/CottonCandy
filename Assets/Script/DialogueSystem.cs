using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditorInternal;
using JetBrains.Annotations;



public class DialogueSystem : MonoBehaviour
{
    private static DialogueSystem _instance;
    public static DialogueSystem Instance { get { return _instance; } }

    
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    
    public bool isDialogue = false;
    
    private int index;


    private void Awake()
    {
        
            _instance = this;
        
    }

    void Start()
    {
        textComponent.text = string.Empty;
        //StartDialogue();
    }
    
    // Update is called once per frame
    void Update()
    {
        /*if (isDialogue == true)
        {
            PlayerControl.Instance.speed = 0;

        }
        else if (isDialogue == false)
        {
            PlayerControl.Instance.speed = 5;
            Debug.Log("Set Speed to Normal");
        }*/

        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
        isDialogue = true;

    }

    private IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine (TypeLine());
        }
        else
        {
            AreaInteraction.Instance.NPCPanel.SetActive(false);
            isDialogue = false;
        }
    }
}
