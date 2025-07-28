using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public GameObject[] sceneImg;

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
        curtain.SetTrigger("Drop");
        isInputEnabled = false;
        yield return new WaitForSeconds(holdSec);
        for (int i = 0; i < sceneImg.Length; i++)
        {
            sceneImg[i].gameObject.SetActive(false);
        }
        currentImage++;
        sceneImg[currentImage].gameObject.SetActive(true);
        //SceneManager.LoadSceneAsync(sceneNumber);
        curtain.SetTrigger("Lift");
        yield return new WaitForSeconds(1);
        isInputEnabled = true;
    }
}
