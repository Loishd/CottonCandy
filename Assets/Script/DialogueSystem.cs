using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditorInternal;
using JetBrains.Annotations;
using Unity.VisualScripting;
using System;
using UnityEngine.UI;


[Serializable]
public struct DialogueResources
{
    public Sprite imagesprite;
    public string name;
    public string text;
    public int numIndex;
};

public class DialogueSystem : MonoBehaviour
{

    public PlayerStatus isdial;
    public TextMeshProUGUI textComponent;
    public TextMeshProUGUI nameComponent;
    public DialogueResources[] lines;
    public float textSpeed;
    public Image characterImage;
    private AudioSource audioSource;
    [SerializeField] private AudioClip dialogueTypingSoundClip; [Range(1, 5)]
    [SerializeField] private int frequencyLevel = 1;
    [SerializeField] private bool StopAudioSource;

    [Range(1, 5)] public int num_Index = 1; 


    private void SelectIndex(int SFX_Index)
    {

        if (SFX_Index == 1)
        {
            PlaySFX01();
        }
        else if (SFX_Index == 2)
        {
            PlaySFX02();
        }
        else if (SFX_Index == 3)
        {
            PlaySFX03();
        }
        else if (SFX_Index == 4)
        {
            PlaySFX04();
        }
        else if (SFX_Index == 5)
        {
            PlaySFX05();
        }

    }
    public void PlaySFX01()
    {
        SoundManager.Instance.PlaySound2D("SFX01");
    }
    public void PlaySFX02()
    {
        SoundManager.Instance.PlaySound2D("SFX02");
    }
    public void PlaySFX03()
    {
        SoundManager.Instance.PlaySound2D("SFX03");
    }
    public void PlaySFX04()
    {
        SoundManager.Instance.PlaySound2D("SFX04");
    }
    public void PlaySFX05()
    {
        SoundManager.Instance.PlaySound2D("SFX05");
    }


    private int index;
    private void playDialogueSound(int currentDisplayedChraracterCount)
    {
        if (currentDisplayedChraracterCount % frequencyLevel == 0)
        {

            /*audioSource.PlayOneShot(dialogueTypingSoundClip);*/
            SelectIndex(num_Index);

        }
    }
    


    private void Awake()
    {
        audioSource = this.gameObject.AddComponent<AudioSource>();
        int SFX_Index = 1;
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
            if (textComponent.text == lines[index].text)
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index].text;
                nameComponent.text = lines[index].name;
            }
        }
    }

    public void StartDialogue()
    {
        index = 0;
        characterImage.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        StartCoroutine(TypeLine());
        

    }

    private IEnumerator TypeLine()
    {
        characterImage.sprite = lines[index].imagesprite;
        foreach (char c in lines[index].text.ToCharArray())
        {
            int characterCount = 0;
            textComponent.text += c;
            nameComponent.text = lines[index].name;
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
            nameComponent.text = string.Empty;
            StartCoroutine (TypeLine());
        }
        else
        {
            this.gameObject.SetActive(false);
            characterImage.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
            isdial.isDialogue = false;
        }
    }
}
