using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

[Serializable]
public struct IntroDontDropCurtain
{
    public GameObject image;
    public GameObject subtitle;
    public bool dontDropCurtain;
}
public class IntroSequence : MonoBehaviour
{
    public static CutsceneSystem instance;
    [SerializeField] Animator curtain;
    //[SerializeField] Animator buttons;
    //[SerializeField] public GameObject _frame;
    //[SerializeField] public GameObject _endFrame;
    [SerializeField] string sceneName;
    [SerializeField] int holdSec;
    int currentImage = 0;
    bool start = true;
    public bool isInputEnabled = true;
    //PlayerInput input = new PlayerInput();

    public IntroDontDropCurtain[] sceneImg;

    void Start()
    {
        curtain.SetTrigger("Lift");
        start = false;

        for (int i = 0; i < sceneImg.Length; i++)
        {
            sceneImg[i].image.gameObject.SetActive(false);
            sceneImg[i].subtitle.gameObject.SetActive(false);
        }

        sceneImg[currentImage].image.gameObject.SetActive(true);
        sceneImg[currentImage].subtitle.gameObject.SetActive(true);
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
            if (Input.GetMouseButtonDown(0))
            {
                {
                    StartCoroutine(LoadScene());
                }
            }
        }
    }
    IEnumerator LoadScene()
    {
        curtain.SetTrigger("Drop");
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(sceneName);
        //transitionAnim.SetTrigger("Start");
    }
    IEnumerator LoadImage()
    {
        if (sceneImg[currentImage].dontDropCurtain == false)
        {
            curtain.SetTrigger("Drop");
            isInputEnabled = false;
            yield return new WaitForSeconds(holdSec);
        }


        for (int i = 0; i < sceneImg.Length; i++)
        {
            sceneImg[i].image.gameObject.SetActive(false);
            sceneImg[i].subtitle.gameObject.SetActive(false);
        }

        currentImage++;
        sceneImg[currentImage].image.gameObject.SetActive(true);
        sceneImg[currentImage].subtitle.gameObject.SetActive(true);
        //SceneManager.LoadSceneAsync(sceneNumber);

        if (sceneImg[currentImage - 1].dontDropCurtain == false)
        {
            curtain.SetTrigger("Lift");
            yield return new WaitForSeconds(1);
        }

        isInputEnabled = true;
    }
}
