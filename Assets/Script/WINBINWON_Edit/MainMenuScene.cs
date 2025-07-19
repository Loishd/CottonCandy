using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScene : MonoBehaviour
{
    public void Scene_MainMenu()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
