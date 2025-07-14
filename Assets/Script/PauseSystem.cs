using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PauseSystem : MonoBehaviour
{
    private static PauseSystem _instance;
    public static PauseSystem instance = _instance;

    public static bool isPaused = false;
    [SerializeField] public GameObject _pauseScreen;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        instance = _instance;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }
    public void TogglePause()
    {
        isPaused = !isPaused;
        Debug.Log("Paused");
        if (isPaused)
        {
            Time.timeScale = 0f; // Pause the game
            AudioListener.pause = true; // Optionally pause all audio
            _pauseScreen.SetActive(true); // Show the pause menu
        }
        else
        {
            Time.timeScale = 1f; // Resume normal time
            AudioListener.pause = false; // Optionally unpause all audio
            _pauseScreen.SetActive(false); // Hide the pause menu
        }
    }
}
