using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TEST01 : MonoBehaviour
{
    [Range(1,5)] public float Delay_num = 2f;
    public int Num = 0;
    public GameObject[] Frame;
    void Start()
    {
        foreach (var frame in Frame)
        {
            frame.SetActive(false);
        }
    }
        void Update()
    {
        /*      if (Input.GetMouseButtonDown(0))
               {


                   Frame[Num].SetActive(false);
                   print(Num);
                   Num += 1;
                   return;
               }*/


    }
    public void NextFrame()
    {
        if (Frame.Length > 0)
        {
            StartCoroutine(Delay01(Delay_num));
            Frame[Num].SetActive(true);
            print(Num);
            Num += 1;
            Frame[Num-2].SetActive(false);
            return;
        }
    }
    private IEnumerator Delay01(float delay)
    {
        yield return new WaitForSeconds(delay);
    }
    
}