using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class AAAAAAAAAA : MonoBehaviour
{
    int clickedCount = 0;
    private Button clicked1 ,click2;
    private Vector3 position1,position2;
    public void forBtn(Button btn)
    {
        btn.transform.localScale= new Vector2(1.2f,12f);
    }
    void Start()
    {
    }
    int a = 0;

    private void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            a = 0;
            a -= 1;
            if (a <= 0)
            {
                Debug.Log(a);
                clicked1.transform.position = Vector3.Lerp(clicked1.transform.position, position2, 10f * Time.deltaTime);
                a += 1;

            }
            if (clickedCount == 2)
            {
               
            }

        }
    }
}