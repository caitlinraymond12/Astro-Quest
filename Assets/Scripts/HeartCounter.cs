using UnityEngine;
using TMPro;

public class HeartCounter : MonoBehaviour
{
    public int heartCounter = 1;
    public AudioSource heartCollect;
    public GameObject gameOver;

    void Start()
    {
        heartCollect = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(heartCounter == 0)
        {
            gameOver.SetActive(true);
        }
    }

}
