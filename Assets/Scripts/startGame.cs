using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingScene : MonoBehaviour
{
    public int scene;
    public int select;
    public void PlayGame()
    {
        SceneManager.LoadScene(scene);
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(select);
    }
}

