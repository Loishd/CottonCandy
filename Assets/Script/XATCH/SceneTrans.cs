using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;
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
        PlayerPrefs.SetInt("RetryBefore", 1);
        Debug.Log("smg");
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(sceneName);
        
        //transitionAnim.SetTrigger("Start");
    }
}
