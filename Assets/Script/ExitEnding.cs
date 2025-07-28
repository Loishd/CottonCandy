using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitEnding : MonoBehaviour
{
    public bool canExit;
    void Start()
    {
        canExit = false;
    }

    IEnumerator PadlockEndingInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("PadlockEnding");
    }

    void Update()
    {
        if (PlayerStatus.instance.sketchFlowerSuccessfully == true)
        {
            if (canExit == true)
            {
                Debug.Log("Insert Exit Job Ending!");
                PlayerPrefs.SetInt("Ending7", 1);
                StartCoroutine(PadlockEndingInDelay());
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) //if player in this area can interact
    {
        if (collision.CompareTag("Player"))
        {
            canExit = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision) //if player in this area cannot interact
    {
        if (collision.CompareTag("Player"))
        {
            canExit = false;

        }

    }
}
