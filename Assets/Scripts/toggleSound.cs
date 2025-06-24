using UnityEngine;

public class toggleSound : MonoBehaviour
{

    private bool playing = true;
    private AudioSource backgroundMusic;

    void Start()
    {
        backgroundMusic = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            if(playing)
               backgroundMusic.Pause();
            else
                backgroundMusic.Play();
            playing = !playing;
        }
    }


}
