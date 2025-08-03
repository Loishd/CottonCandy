using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[Serializable]
public class MainMenu : MonoBehaviour
{

    private static MainMenu _instance;
    public static MainMenu instance => _instance;
    public AudioMixer audioMixer;
    public Slider musicSlider;
    public Slider sfxSlider;
    public PlayableDirector fadeInDirector;
    public PlayableDirector fadeOutDirector;
    public GameObject Trasition;
    public GameObject PausedScreen;
    public GameObject GalleryScreen;
    public Boolean GalleryPinEnding1, GalleryPinEnding2, GalleryPinEnding3 , GalleryPinEnding4 , GalleryPinEnding5, GalleryPinEnding6, GalleryPinEnding7, GalleryPinEnding8, GalleryPinEnding9, GalleryPinEnding10;
    
    
    private void Awake()
    {

        Trasition.SetActive(true);
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
        CutScene_FadeOut();
        Play();
        LoadVolume();
        /*MusicManager.Instance.PlayMusic("MusicSource");*/
        
    }

    private void Update()
    {

        Badge_Checked();
        
    }
    public void Badge_Checked()
    {
        
            if (PlayerPrefs.GetInt("Ending1") == 0)
            {
                GalleryPinEnding1 = false;
           
            }
            else
            {
                GalleryPinEnding1 = true;
            }
            if (PlayerPrefs.GetInt("Ending2") == 0)
            {
                GalleryPinEnding2 = false;
            
            }
            else
            {
                GalleryPinEnding2 = true;
            
            }
            if (PlayerPrefs.GetInt("Ending3") == 0)
            {
                GalleryPinEnding3 = false;
          
            }
            else
            {
                GalleryPinEnding3 = true;


            }

            if (PlayerPrefs.GetInt("Ending4") == 0)
            {
                GalleryPinEnding4 = false;
         
            }
            else
            {
                GalleryPinEnding4 = true;
       
            }

            if (PlayerPrefs.GetInt("Ending5") == 0)
            {
                GalleryPinEnding5 = false;
        
            }
            else
            {
                GalleryPinEnding5 = true;
          
            }

            if (PlayerPrefs.GetInt("Ending6") == 0)
            {
                GalleryPinEnding6 = false;
         
            }
            else
            {
                GalleryPinEnding6 = true;
            }

            if (PlayerPrefs.GetInt("Ending7") == 0)
            {
                GalleryPinEnding7 = false;
            }
            else
            {
                GalleryPinEnding7 = true;
            }
            if (PlayerPrefs.GetInt("Ending8") == 0)
            {
                GalleryPinEnding8= false;
            }
            else
            {
                GalleryPinEnding8 = true;
            }

            if (PlayerPrefs.GetInt("Ending9") == 0)
            {
                 GalleryPinEnding9 = false;
            }
            else
            {
                GalleryPinEnding9 = true;
            }
            if (PlayerPrefs.GetInt("Ending10") == 0)
            {
                GalleryPinEnding10 = false;
            }
            else
            {
                GalleryPinEnding10 = true;
            }
       
        }
    
    public void CutScene_FadeIn()
    {
        fadeInDirector.Play();
    }
    public void CutScene_FadeOut()
    {
        fadeOutDirector.Play();
    }
    public void Test()
    {
        SoundManager.Instance.PlaySound2D("SFX01");
        PlayerPrefs.SetInt("Ending4", 1);
    }
    public void AllPinOn()
    {
        PlayerPrefs.SetInt("Ending1", 1);
        PlayerPrefs.SetInt("Ending2", 1);
        PlayerPrefs.SetInt("Ending3", 1);
        PlayerPrefs.SetInt("Ending4", 1);
        PlayerPrefs.SetInt("Ending5", 1);
        PlayerPrefs.SetInt("Ending6", 1);
        PlayerPrefs.SetInt("Ending7", 1);
        PlayerPrefs.SetInt("Ending8", 1);
        PlayerPrefs.SetInt("Ending9", 1);
        PlayerPrefs.SetInt("Ending10",1);
    }

    public void AllPinOff()
    {
        PlayerPrefs.SetInt("Ending1", 0);
        PlayerPrefs.SetInt("Ending2", 0);
        PlayerPrefs.SetInt("Ending3", 0);
        PlayerPrefs.SetInt("Ending4", 0);
        PlayerPrefs.SetInt("Ending5", 0);
        PlayerPrefs.SetInt("Ending6", 0);
        PlayerPrefs.SetInt("Ending7", 0);
        PlayerPrefs.SetInt("Ending8", 0);
        PlayerPrefs.SetInt("Ending9", 0);
        PlayerPrefs.SetInt("Ending10",0);
    }
    public void OpenMusicButton()
    {

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

    public void PrepareQuit()
    {
        if (TabBoolean == false)
        {
            PausedScreen.SetActive(true);
            TabBoolean = true;
            return;
        }
    }

    public void PrepareStay()
    {
        PausedScreen.SetActive(false);
        TabBoolean = false;
        return;
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
    public void CutScene()
    {
        StartCoroutine(delayScene00());

    }
    public void Scene_MainMenu()
    {
        StartCoroutine(delayScene01());

    }
    public void LoadScene()
    {
        StartCoroutine(StartScene101());

    }
    IEnumerator StartScene101()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Intro");
    }

    IEnumerator delayScene00()
    {
        CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadSceneAsync(2);
        yield return new WaitForSeconds(2);
        Trasition.SetActive(false);
    }
    IEnumerator delayScene01()
    {
        CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadSceneAsync("MainMenu");
        yield return new WaitForSeconds(2);
        Trasition.SetActive(false);
    }
    IEnumerator delayScene02()
    {
        CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadSceneAsync("SampleScene");
        yield return new WaitForSeconds(2);
        Trasition.SetActive(false);
    }

    public void Badge_LoveBugEnding()
    {
        if (GalleryPinEnding6 == true)
        {
            StartCoroutine(LoveBugEndingInDelay());
        }
        
    }//1 LadyBug

    public void Badge_PodcastEnding()
    {
        if(GalleryPinEnding2 == true)
        {
            StartCoroutine(PodcastEndingInDelay());
        }
        
    }//2 Podcast
    public void Badge_AFKEnding()
    {
        if (GalleryPinEnding10 == true)
        {
            StartCoroutine(AFKEndingInDelay());
        }
    }//3 AFK

    public void Badge_AxeEndingScene()
    {

        if (GalleryPinEnding1 == true)
        {
            StartCoroutine(AxeEndingInDelay());
        }
        
        
    }//4 Axe
    public void Badge_FlowerStudent()
    {
        if (GalleryPinEnding5 == true)
        {
            StartCoroutine(FlowerStudentInDelay());
        }

        
    }//5 Flower
    public void Badge_FoodEnding()
    {

        if (GalleryPinEnding9 == true)
        {
    StartCoroutine(FoodEndingInDelay());
        }
       
    }//6 Lunch
    public void Badge_SewkitStudent()
    {
        if (GalleryPinEnding4 == true)
        {
            StartCoroutine(SewkitStudentInDelay());
        }

        
    }//7 Sew
    public void Badge_DollEnding()
    {
        if (GalleryPinEnding3 == true)
        {
            StartCoroutine(DollEndingInDelay());
        }

        
    }//8 Doll
    public void Badge_SketchNotepadEnding()
    {
        if (GalleryPinEnding8 == true)
        {
            StartCoroutine(SketchNotepadEndingInDelay());
        }
        
    }//9 NotePad

    public void Badge_PadlockEnding()
    {
        if (GalleryPinEnding7 == true)
        {
            StartCoroutine(PadlockEndingInDelay());
        }
        
    }//10
    IEnumerator PadlockEndingInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("PadlockEnding");
    }
    IEnumerator AxeEndingInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("AxeEnding");
    }
    IEnumerator FlowerStudentInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Flower");
    }
    IEnumerator FoodEndingInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("LunchEnding");

    }
    IEnumerator SewkitStudentInDelay()
    {

        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("SewEnding");

    }
    IEnumerator DollEndingInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("DollEnding");
    }

    IEnumerator SketchNotepadEndingInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("NotepadEnding");

    }
    IEnumerator AFKEndingInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("AFKEnding");

    }

    IEnumerator PodcastEndingInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("PodcastEnding");
    }
    IEnumerator LoveBugEndingInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("LoveBugEnding");
    }


}
