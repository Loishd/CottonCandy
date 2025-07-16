using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.UIElements;

public class Gallery : MonoBehaviour
{

    public bool Gallery_Lock;
    public int Gallery_Index;
      
    public bool clickedAble = false;
    void Start()
    {
        UnlockGallery();
        Gallery_Index = 0;
        Gallery_Lock = true;
        Clickable();
        StartCoroutine(DelayExample());
    }
    void Update()
    {
        
        
    }
    IEnumerator DelayExample()
    {
        yield return new WaitForSeconds(2f);
    }
    
    public void UnlockGallery()
    {
        Gallery_Lock = false;
        Debug.Log("Unlock");
        clickedAble = Gallery_Lock;
    }
    public void LockGallery()
    {
        Gallery_Lock = true;
        Debug.Log("Lock");
        clickedAble = Gallery_Lock;
    }
    public void ToggleGallery()
    {
        Gallery_Lock = !Gallery_Lock;
        Debug.Log("Gallery_Lock = " + Gallery_Lock);
        UpdateButtonLabel(); 
    }
    void UpdateButtonLabel()
    {
        //Text btnText = btnText.GetComponentInChildren<Text>();
        //if (btnText != null)
        {
            //btnText.text = Gallery_Lock ? "Lock" : "Unlock";
        }
    }

    public void Clickable()
    {
        if (clickedAble == true)
        {
            Debug.Log("1");
        }

        else if (clickedAble == false)
        {
            Debug.Log("0");
        }

    }


}
