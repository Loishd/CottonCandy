using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SaveEnding : MonoBehaviour
{
    public TextMeshProUGUI textEnding1;


    void Start()
    {
        if (!PlayerPrefs.HasKey("HasLaunchedBefore"))
        {
            // First time launching the game
            PlayerPrefs.SetInt("Ending1", 0);
            PlayerPrefs.SetInt("Ending2", 0);
            PlayerPrefs.SetInt("Ending3", 0);
            PlayerPrefs.SetInt("Ending4", 0);
            PlayerPrefs.SetInt("Ending5", 0);
            PlayerPrefs.SetInt("Ending6", 0);
            PlayerPrefs.SetInt("Ending7", 0);
            PlayerPrefs.SetInt("Ending8", 0);
            PlayerPrefs.SetInt("Ending9", 0);
            PlayerPrefs.SetInt("Ending10", 0);

            // Mark as launched
            PlayerPrefs.SetInt("HasLaunchedBefore", 1);
            PlayerPrefs.Save(); // Optional but good practice to save right away
        }
    }


    void Update()
    {
        if (PlayerPrefs.GetInt("Ending1") == 0)
        {
            textEnding1.text = "Ending1 Not Ended Yet";
        }
        else
        {
            textEnding1.text = "Ending1 Ended";
        }
    }
}
