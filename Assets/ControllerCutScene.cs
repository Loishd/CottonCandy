using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class ControllerCutScene : MonoBehaviour
{
    [Range(1, 5)] public float Delay_num = 2f;
    public int Num = 0;
    public GameObject[] Frame;
    public PlayableDirector DropDirector;
    public PlayableDirector LiftDirector;
    void Start()
    {
        LiftCurtain();
    }
    void Update() 
    {
        foreach (var frame in Frame)
        {
            frame.SetActive(false);
        }

    }
    public void NextFrame()
    {
        if (Frame.Length > 0)
        {
            StartCoroutine(Delay01(Delay_num));
            Frame[Num].SetActive(true);
            print(Num);
            Num += 1;
            Frame[Num - 2].SetActive(false);
            return;
        }
    }
    private IEnumerator Delay01(float delay)
    {
        yield return new WaitForSeconds(delay);
    }
 

 
    public void LiftCurtain()
    {
        LiftDirector.Play();
    }
    public void DropCurtain()
    {
        DropDirector.Play();
    }

}
