using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEditorInternal;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource SFXSource;
    public AudioSource background;
    public float timer = 600f;
    

    private static GameManager _instance;
    public static GameManager instance => _instance;

    public GameObject _pausedScreen;

   

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

    }



  
    

}
