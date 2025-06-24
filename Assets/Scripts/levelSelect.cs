using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelect : MonoBehaviour
{
    public void levelOne()
    {
        SceneManager.LoadScene(1);
    }
    public void levelTwo()
    {
        SceneManager.LoadScene(2);
    }
    public void levelThree()
    {
        SceneManager.LoadScene(3);
    }
    public void levelFour()
    {
        SceneManager.LoadScene(4);
    }
}
