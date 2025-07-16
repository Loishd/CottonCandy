using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class ItemChecker : MonoBehaviour
{
    private string ItemName;
    public int ItemValue;
    public bool pickedUpItem = false;

    private static ItemChecker _instance;
    public static ItemChecker Instance { get { return _instance; } }

    private void Awake()
    {
        _instance = this;

    }

    void Start()
    {
        ItemName = name.Substring(0, 5);

        switch (ItemName)
        {
            case "Item1":
                ItemValue = 10;
                break;

            case "Item2":
                ItemValue = 1;
                break;
        }
    }

    
    void Update()
    {
        
    }
}
