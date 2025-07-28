using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SaveEnding : MonoBehaviour
{
    public Image dollBadge;
    public Image padlockBadge;
    public Image lovebugBadge;
    public Image afkBadge;
    public Image axeBadge;
    public Image podcastBadge;
    public Image flowerBadge;
    public Image sewedBadge;
    public Image notepadBadge;
    public Image lunchBadge;

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
            axeBadge.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        }
        else
        {
            axeBadge.color = new Color(1f, 1f, 1f, 1f);
        }

        if (PlayerPrefs.GetInt("Ending2") == 0)
        {
            podcastBadge.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        }
        else
        {
            podcastBadge.color = new Color(1f, 1f, 1f, 1f);
        }

        if (PlayerPrefs.GetInt("Ending3") == 0)
        {
            dollBadge.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        }
        else
        {
            dollBadge.color = new Color(1f, 1f, 1f, 1f);
        }

        if (PlayerPrefs.GetInt("Ending4") == 0)
        {
            sewedBadge.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        }
        else
        {
            sewedBadge.color = new Color(1f, 1f, 1f, 1f);
        }

        if (PlayerPrefs.GetInt("Ending5") == 0)
        {
            flowerBadge.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        }
        else
        {
            flowerBadge.color = new Color(1f, 1f, 1f, 1f);
        }

        if (PlayerPrefs.GetInt("Ending6") == 0)
        {
            lovebugBadge.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        }
        else
        {
            lovebugBadge.color = new Color(1f, 1f, 1f, 1f);
        }

        if (PlayerPrefs.GetInt("Ending7") == 0)
        {
            padlockBadge.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        }
        else
        {
            padlockBadge.color = new Color(1f, 1f, 1f, 1f);
        }

        if (PlayerPrefs.GetInt("Ending8") == 0)
        {
            notepadBadge.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        }
        else
        {
            notepadBadge.color = new Color(1f, 1f, 1f, 1f);
        }

        if (PlayerPrefs.GetInt("Ending9") == 0)
        {
            lunchBadge.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        }
        else
        {
            lunchBadge.color = new Color(1f, 1f, 1f, 1f);
        }

        if (PlayerPrefs.GetInt("Ending10") == 0)
        {
            afkBadge.color = new Color(0.5f, 0.5f, 0.5f, 1f);
        }
        else
        {
            afkBadge.color = new Color(1f, 1f, 1f, 1f);
        }

    }
}
