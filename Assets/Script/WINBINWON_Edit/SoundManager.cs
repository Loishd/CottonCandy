using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
  
    public static SoundManager Instance;

    [SerializeField]
    private SoundLibrary sfxLibrary;
    [SerializeField]
    private AudioSource sfx2DSource;
    public void PlaySFX01()
    {
        SoundManager.Instance.PlaySound2D("SFX01");
    }
    public void PlaySFX02()
    {
        SoundManager.Instance.PlaySound2D("SFX02");
    }
    public void PlaySFX03()
    {
        SoundManager.Instance.PlaySound2D("SFX03");
    }
    public void PlaySFX04()
    {
        SoundManager.Instance.PlaySound2D("SFX04");
    }
    public void PlaySFX05()
    {
        SoundManager.Instance.PlaySound2D("SFX05");
    }
    public void PlayFootstepSound()
    {
        SoundManager.Instance.PlaySound2D("SFX_FOOTSTEP");
    }
    public void PlayUIclick()
    {
        SoundManager.Instance.PlaySound2D("SFX_UI");
    }


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PlaySound3D(AudioClip clip, Vector3 pos)
    {
        if (clip != null)
        {
            AudioSource.PlayClipAtPoint(clip, pos);
        }
    }

    public void PlaySound3D(string soundName, Vector3 pos)
    {
        PlaySound3D(sfxLibrary.GetClipFromName(soundName), pos);                                                                            
    }

    public void PlaySound2D(string soundName)
    {
        sfx2DSource.PlayOneShot(sfxLibrary.GetClipFromName(soundName));
    }
}
