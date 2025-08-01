using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GalleryScript : MonoBehaviour
{
    public GameObject GalleryScreen;
    void Start()
    {

    }


    void Update()
    {

    }
    public void AxeEndingScene()
    {
        GalleryScreen.gameObject.SetActive(false);
        StartCoroutine(AxeEndingInDelay());

    }
    public void FlowerStudent()
    {
        GalleryScreen.gameObject.SetActive(false);
        StartCoroutine(FlowerStudentInDelay());
    }
    public void FoodEnding()
    {
        GalleryScreen.gameObject.SetActive(false);
        StartCoroutine(FoodEndingInDelay());
    }
    public void sewkitStudent()
    {
        GalleryScreen.gameObject.SetActive(false);
        StartCoroutine(sewkitStudentInDelay());
    }
    public void dollEnding()
    {
        GalleryScreen.gameObject.SetActive(false);
        StartCoroutine(dollEndingInDelay());
    }
    public void sketchNotepadEnding()
    {
        GalleryScreen.gameObject.SetActive(false);
        StartCoroutine(sketchNotepadEndingInDelay());
    }
    public void AFKEnding()
    {
        StartCoroutine(sketchNotepadEndingInDelay());
    }
    public void 


        IEnumerator()
    {

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
    IEnumerator sewkitStudentInDelay()
    {   
        
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("SewEnding");
        
    }
    IEnumerator dollEndingInDelay()
    {
        MainMenu.instance.CutScene_FadeIn();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("DollEnding");
    }

    IEnumerator sketchNotepadEndingInDelay()
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
}
