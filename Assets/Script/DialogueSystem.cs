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
    private AudioSource audioSource;
    [SerializeField] private AudioClip dialogueTypingSoundClip; [Range(1, 5)]
    [SerializeField] private int frequencyLevel = 1;
    [SerializeField] private bool StopAudioSource;
    




    private int index;
    private void playDialogueSound(int currentDisplayedChraracterCount)
    {
        if (currentDisplayedChraracterCount % frequencyLevel == 0)
        {
            audioSource.PlayOneShot(dialogueTypingSoundClip);
        }
    }


    private void Awake()
    {
        audioSource = this.gameObject.AddComponent<AudioSource>();
        /*textComponent.text = string.Empty;*/
    }
    
    void Start()
    {
        
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
            int characterCount = 0;
            textComponent.text += c;
            if (!char.IsWhiteSpace(c) && char.IsLetterOrDigit(c))
            {
                characterCount++;
                playDialogueSound(c);
            }

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
