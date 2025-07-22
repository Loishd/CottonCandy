using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    private static PlayerStatus _instance;
    public static PlayerStatus instance => _instance;
    public bool isDialogue; //is talking
    public bool pickupitemstatus; //pick up yet?
    public bool acceptSteakQuest;
    public bool steakQuestSuccessfully;
    public bool HaveNeedle;
    public bool HaveThread;
    public bool acceptDollQuest;
    public bool dollQuestSuccessfully;
    public bool foundSpeaker;
    public bool acceptColinQuest;
    public bool colinQuestsuccessfully;

    public List<ItemQuest> itembag = new List<ItemQuest>();

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
        pickupitemstatus = false;
        acceptSteakQuest = false;
        steakQuestSuccessfully = false;
        acceptDollQuest = false;
        dollQuestSuccessfully = false;
        foundSpeaker = false;
        acceptColinQuest = false;
        colinQuestsuccessfully = false;
        HaveNeedle = false;
        HaveThread = false;
}

    
    void Update()
    {
        
    }

    public bool checkItem(ItemQuest item)
    {
        foreach (ItemQuest itemstring in itembag)
        {
            if (itemstring == item)
            {
                return true;
            }
        }
        return false;
    }

    public void addItem(ItemQuest item)
    {
        itembag.Add(item);
        item = bagUI.instance.it1;
    }

    public bool checkItemAndRemove(ItemQuest item)
    {
        foreach (ItemQuest itemstring in itembag)
        {
            if (itemstring == item)
            {
                itembag.Remove(item);
                return true;
            }
        }
        return false;
    }

    

    






}
