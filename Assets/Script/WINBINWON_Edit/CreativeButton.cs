using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreativeButton : MonoBehaviour
{
    private void Start()
    {
        Image img = GetComponent<Image>();
        if (img == null)
        {
            Debug.LogError("no img" + gameObject.name);

        }
        else
        {
            img.alphaHitTestMinimumThreshold = 0.1f;
        }
    }
    void Awake()
    {
        
    }                              

    
    void Update()
    {
       
    }
}
