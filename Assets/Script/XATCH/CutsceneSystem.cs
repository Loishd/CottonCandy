using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

[Serializable]
public struct CutsceneDontDropCurtain
{
    public GameObject image;
    public bool dontDropCurtain;
}
public class CutsceneSystem : MonoBehaviour
{
    public static CutsceneSystem instance;
    [SerializeField] Animator curtain;
    [SerializeField] Animator buttons;
    [SerializeField] public GameObject _frame;
    [SerializeField] public GameObject _endFrame;
    [SerializeField] int holdSec;
    int currentImage = 0;
    bool start = true;
    public bool isInputEnabled = true;
    //PlayerInput input = new PlayerInput();

    public CutsceneDontDropCurtain[] sceneImg;

    void Start()
    {
        curtain.SetTrigger("Lift");
        start = false;
    }

    void Update()
    {
        if (!isInputEnabled) return;

        Nextimage();
    }

    public void Nextimage()
    {
        if (currentImage < sceneImg.Length - 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Debug.Log("Click");
                StartCoroutine(LoadImage());
            }
        }
        if (currentImage >= sceneImg.Length - 1)
        {
            _frame.gameObject.SetActive(false);
            buttons.SetTrigger("Rise");
            _endFrame.gameObject.SetActive(true);
        }
    }

    IEnumerator LoadImage()
    {
        if (sceneImg[currentImage].dontDropCurtain == false)
        {
            curtain.SetTrigger("Drop");
        }

        isInputEnabled = false;


        if (sceneImg[currentImage].dontDropCurtain == false)
        {
            yield return new WaitForSeconds(holdSec);
        }


        for (int i = 0; i < sceneImg.Length; i++)
        {
            sceneImg[i].image.gameObject.SetActive(false);
        }

        currentImage++;
        sceneImg[currentImage].image.gameObject.SetActive(true);
        //SceneManager.LoadSceneAsync(sceneNumber);

        if (sceneImg[currentImage - 1].dontDropCurtain == false)
        {
            curtain.SetTrigger("Lift");
        }

        if (sceneImg[currentImage].dontDropCurtain == false)
        {
            yield return new WaitForSeconds(1);
        }

        isInputEnabled = true;
    }
}
