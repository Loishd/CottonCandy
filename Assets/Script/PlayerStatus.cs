using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    private static PlayerStatus _instance;
    public static PlayerStatus instance => _instance;

    [SerializeField] private AreaInteraction areaInt;
    public bool isDialogue; //is talking
    public bool pickupitemstatus; //pick up yet?
    public bool acceptSteakQuest;
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
        item = bagUI.instance.it;
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
