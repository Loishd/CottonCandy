using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditorInternal;
using JetBrains.Annotations;



public class DialogueSystem : MonoBehaviour
{
    
    public PlayerStatus isdial;
    public AreaInteraction Area;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    
    
    
    private int index;


    private void Awake()
    {
        
    }

    void Start()
    {
        textComponent.text = string.Empty;
    }
    
    // Update is called once per frame
    void Update()
    {
        

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
            Area.NPCPanel.SetActive(false);
            isdial.isDialogue = false;
        }
    }
}
