using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneSystem : MonoBehaviour
{
    public static CutsceneSystem instance;
    [SerializeField] Animator curtain;
    [SerializeField] Animator buttons;
    [SerializeField] int totalImage;
    [SerializeField] int holdSec;
    int currentImage = 0;
    bool start = true;

    public GameObject[] sceneImg;

    private void Start()
    {
        curtain.SetTrigger("Lift");
        start = false;
    }

    private void Update()
    {
        Nextimage();
    }

    public void Nextimage()
    {
        if (currentImage < totalImage)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Click");
                StartCoroutine(LoadImage());
            }
        }
        if (currentImage >= totalImage)
        {
            buttons.SetTrigger("Rise");
        }
    }

    IEnumerator LoadImage()
    {
        curtain.SetTrigger("Drop");
        yield return new WaitForSeconds(holdSec);
        currentImage++;
        //SceneManager.LoadSceneAsync(sceneNumber);
        curtain.SetTrigger("Lift");
    }
}
