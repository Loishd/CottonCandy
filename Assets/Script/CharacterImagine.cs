using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterImagine : MonoBehaviour
{
    public static CharacterImagine Instance;
    private Image img;

    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        img = GetComponent<Image>();
    }


    void Update()
    {
        
    }

    public void closeCharacterImage()
    {
        img.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
    }
}
