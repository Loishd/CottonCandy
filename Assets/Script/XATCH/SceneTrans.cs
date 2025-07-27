using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;
    [SerializeField] Animator transitionAnim;
    [SerializeField] int sceneNumber;
    public void NextScene()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("Drop");
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(sceneNumber);
        //transitionAnim.SetTrigger("Start");
    }
}
