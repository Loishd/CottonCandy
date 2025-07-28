using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController2 : MonoBehaviour
{
    public static SceneController2 instance;
    [SerializeField] Animator transitionAnim;
    [SerializeField] int sceneNumber;
    [SerializeField] string sceneName;
    public void NextScene()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("Drop");
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(sceneName);
        //transitionAnim.SetTrigger("Start");
    }
}