using UnityEngine;

public class checkpoint : MonoBehaviour
{
  
    public GameObject respawnPoint;

    public AudioSource checkPointSound;
    void Start()
    {
        checkPointSound = GetComponent<AudioSource>();
        respawnPoint = GameObject.Find("respawnPoint");
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            checkPointSound.Play();
            respawnPoint.transform.position = transform.position;
        }
    }
}
