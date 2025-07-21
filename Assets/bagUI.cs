using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bagUI : MonoBehaviour
{
    private static bagUI _instance;
    public static bagUI instance => _instance;
    public ItemQuest it1;
    public ItemQuest it2;
    public ItemQuest invisIt;
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

        if (PlayerStatus.instance.itembag.Count == 1)
        {
            it1 = PlayerStatus.instance.itembag[0];
            image.sprite = it1.itemSprite;
        }

            if (PlayerStatus.instance.itembag.Count > 1)
            {
                it2 = PlayerStatus.instance.itembag[1];
                image.sprite = it2.itemSprite;
            }

        if (PlayerStatus.instance.itembag.Count <= 0)
        {
            it1 = null;
            image.sprite = invisIt.itemSprite;
        }

    }
}
