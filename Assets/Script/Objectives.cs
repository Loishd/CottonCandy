using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Objectives : MonoBehaviour
{
    private static Objectives _instance;
    public static Objectives instance => _instance;

    public enum CurrentQuest {NoActiveQuest, Quest1, Quest2, Quest3, Quest4, Quest5, Quest6, Quest7, Quest8, Quest9, Quest10, Quest11, Quest12};
    public CurrentQuest cq;
    public TextMeshProUGUI questText;
        

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    void Start()
    {
        cq = CurrentQuest.NoActiveQuest;
        UpdateQuestUI();
    }

    
    void Update()
    {
        
    }

    public void SetQuest(CurrentQuest newQuest)
    {
        cq = newQuest;
        UpdateQuestUI();
    }

    private void UpdateQuestUI()
    {
        if (questText != null)
        {
            if (cq == CurrentQuest.NoActiveQuest)
            {
                questText.text = "Explore";
            }

            else if (cq == CurrentQuest.Quest1)
            {
                questText.text = "Give an axe to someone";
            }

            else if (cq == CurrentQuest.Quest2)
            {
                questText.text = "Find someway to fix this";
            }

            else if (cq == CurrentQuest.Quest3)
            {
                questText.text = "Do something for Terry";
            }

            else if (cq == CurrentQuest.Quest4)
            {
                questText.text = "Open the speaker";
            }

            else if (cq == CurrentQuest.Quest5)
            {
                questText.text = "Find someway to fix that doll";
            }

            else if (cq == CurrentQuest.Quest6)
            {
                questText.text = "Fix it";
            }

            else if (cq == CurrentQuest.Quest7)
            {
                questText.text = "Give it to them";
            }

            else if (cq == CurrentQuest.Quest8)
            {
                questText.text = "Give a flower to someone";
            }

            else if (cq == CurrentQuest.Quest9)
            {
                questText.text = "Leave this place!";
            }

            else if (cq == CurrentQuest.Quest10)
            {
                questText.text = "Find some ingredients for Terry";
            }

            else if (cq == CurrentQuest.Quest11)
            {
                questText.text = "Give it to students!";
            }

            else if (cq == CurrentQuest.Quest12)
            {
                questText.text = "Give it to someone";
            }
        }
    }
}
