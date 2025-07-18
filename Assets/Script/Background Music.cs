using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    bool Toggle = false;
    void Start()
    {
      
    }
    public void ToggleSystem()
    {
        Toggle = !Toggle;
        Debug.Log("Toggle:" + Toggle);
    }

    // Update is called once per frame
    void Update()
    {
        ToggleSystem();
    }
}
