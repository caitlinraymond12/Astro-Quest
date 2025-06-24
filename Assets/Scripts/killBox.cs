using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class killBox : MonoBehaviour
{

    public Transform respawnPoint;
    public HeartCounter heartCounter;
    public TMP_Text heartScoreText;
    public resetPlatforms resetPlatforms;
    private int sceneIndex;



    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(sceneIndex == 4)
            resetPlatforms = GameObject.Find("resetPlatforms").GetComponent<resetPlatforms>();
        heartCounter = GameObject.Find("HeartCounter").GetComponent<HeartCounter>();
        heartScoreText = GameObject.Find("Lives").GetComponent<TMP_Text>();
        
    }
    


    void OnCollisionEnter2D(Collision2D collision)
    {
        respawnPoint = GameObject.Find("respawnPoint").GetComponent<Transform>();
        if(collision.gameObject.tag == "Player")
        {
            if(sceneIndex == 4)
                resetPlatforms.reset = true;
            collision.gameObject.SetActive(false);
            heartCounter.heartCounter -= 1;
            heartScoreText.text = "Lives: " + heartCounter.heartCounter.ToString();
            if(heartCounter.heartCounter != 0)
            {
                collision.transform.position = respawnPoint.position;
                collision.gameObject.SetActive(true);
            }
        }   
    }
}
