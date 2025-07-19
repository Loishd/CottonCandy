using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class MouseHoverScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    int a = 0;
    // Update is called once per frame
    private void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            Debug.Log(a);
            a += 1;
        }
    }
}