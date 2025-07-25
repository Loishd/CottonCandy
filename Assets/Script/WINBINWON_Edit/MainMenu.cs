using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider musicSlider;
    public Slider sfxSlider;

    private void Start()
    {
        Play();
        LoadVolume();
        /*MusicManager.Instance.PlayMusic("MusicSource");*/


    }
    private void Update()
    {

    }
    public void Test()
    {
        SoundManager.Instance.PlaySound2D("SFX01");
    }
    public void Play()
    {/*
        LevelManager.Instance.LoadScene("Game", "CrossFade");*/
        MusicManager.Instance.PlayMusic("BGM");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void UpdateMusicVolume(float volume)
    {
        audioMixer.SetFloat("MusicVolume", volume);
    }

    public void UpdateSoundVolume(float volume)
    {
        audioMixer.SetFloat("SFXVolume", volume);
    }

    public void SaveVolume()
    {
        audioMixer.GetFloat("MusicVolume", out float musicVolume);
        PlayerPrefs.SetFloat("MusicVolume", musicVolume);

        audioMixer.GetFloat("SFXVolume", out float sfxVolume);
        PlayerPrefs.SetFloat("SFXVolume", sfxVolume);
    }
    [SerializeField] private GameObject pannel;
    [SerializeField] private GameObject GalleryTab;
    [SerializeField] private GameObject CreditTab;
    bool TabBoolean = false;

    public void OnTabGallery()
    {
        if (TabBoolean == false)
        {
            GalleryTab.SetActive(true);
            TabBoolean = true;
            return;
        }

    }
    public void OffTabGallery()
    {
        if (TabBoolean == true)
        {
            GalleryTab.SetActive(false);
            TabBoolean = false;
            return;
        }
    }
    public void OnTabCredit()
    {
        if (TabBoolean == false)
        {
            CreditTab.SetActive(true);
            TabBoolean = true;
            return;
        }

    }

    public void OffTabCredit()
    {
        if (TabBoolean == true)
        {
            CreditTab.SetActive(false);
            TabBoolean = false;
            return;
        }
    }
    void OpenTabs()
    {
        if (pannel.activeSelf == false)
        {
            pannel.SetActive(true);
            return;
        }

    }
    public void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume");
    }
    public void LoadScene()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void Scene_MainMenu()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
