using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource BG_music;
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

        if (Toggle == true)
        {
            
        }
    }
}
