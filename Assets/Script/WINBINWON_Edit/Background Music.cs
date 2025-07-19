using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    AudioSource Music;
    bool Toggle = false;
    void Start()
    {
      
    }
    public void ToggleSystem()
    {
        Toggle = !Toggle;
        Debug.Log("Toggle:" + Toggle);
        
    }

    
    void Update()
    {

       
    }
}
