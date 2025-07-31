using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveRetry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("HasLaunchedBefore"))
        {
            // First time launching the game
            //retry before
            PlayerPrefs.SetInt("RetryBefore", 0);

            // Mark as launched
            PlayerPrefs.SetInt("HasLaunchedBefore", 1);
            PlayerPrefs.Save(); // Optional but good practice to save right away
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
