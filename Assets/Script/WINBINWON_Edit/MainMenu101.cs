using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutScene : MonoBehaviour
{
    public PlayableDirector fadeOutDirector;
    public PlayableDirector fadeInDirector;

    private void Start()
    {
        CutScene_FadeOut();
      
    }
    public void CutScene_FadeIn()
    {
        fadeInDirector.Play();
    }
    public void CutScene_FadeOut()
    {
        fadeOutDirector.Play();
    }


}
