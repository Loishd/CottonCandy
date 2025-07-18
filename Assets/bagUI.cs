using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bagUI : MonoBehaviour
{
    public ItemQuest it;
    private Image image;
    void Start()
    {
        image = GetComponent<Image>();
        image.sprite = it.itemSprite;
        
    }

    
    void Update()
    {
        
    }
}
