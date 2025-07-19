using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bagUI : MonoBehaviour
{
    private static bagUI _instance;
    public static bagUI instance => _instance;
    public ItemQuest it;
    private Image image;
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
        image = GetComponent<Image>();
        
        
    }

    
    void Update()
    {
        if (PlayerStatus.instance.pickupitemstatus == true)
        {
            
            image.sprite = it.itemSprite;
        }
    }
}
