using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTabs : MonoBehaviour
{
    [SerializeField]private GameObject pannel;
    [SerializeField] private GameObject GalleryTab;
    [SerializeField] private GameObject CreditTab;
    bool TabBoolean = false;
    int a = 0;
    public void OnTabGallery()
    {
        if (TabBoolean == false)
        {
            GalleryTab.SetActive(true);
            TabBoolean = true;
            return;
        }

    }
    public void OffTabGallery()
    {
        if (TabBoolean == true)
        {
            GalleryTab.SetActive(false);
            TabBoolean = false;
            return;
        }
    }
    public void OnTabCredit()
    {
        if (TabBoolean == false)
        {
            CreditTab.SetActive(true);
            TabBoolean = true;
            return;
        }
            
    }

    public void OffTabCredit()
    {
        if (TabBoolean == true)
        {
            CreditTab.SetActive(false);
            TabBoolean = false;
            return;
        }
        }
        void OpenTabs()
    {
        if (pannel.activeSelf == false)
        {
            pannel.SetActive(true);
            return;
        }
        
    }
    void Panel()
    {

    }
    ////If Else Condition 
    // if (pannel.activeSelf == true)
    //    {
            
    //    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (TabBoolean == true)
        {

        }
    }
}
