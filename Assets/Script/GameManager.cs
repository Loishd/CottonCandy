using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource SFXSource;
    public AudioSource background;
    public float timer = 600f;
    

    private static GameManager _instance;
    public static GameManager instance => _instance;

    public GameObject _pausedScreen;


    IEnumerator AFKEndingInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("AFKEnding");
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    private void Start()
    {
        StartCoroutine(CountdownCoroutine(timer));  
    }

    IEnumerator CountdownCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("Insert AFK ending here");
        PlayerPrefs.SetInt("Ending10", 1);
        StartCoroutine(AFKEndingInDelay());
    }



  
    

}
