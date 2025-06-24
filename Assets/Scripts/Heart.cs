using UnityEngine;
using TMPro;
public class Heart : MonoBehaviour
{
    public HeartCounter heartCounter;
    public TMP_Text heartScoreText;
    
    

    void Start()
    {
        heartCounter = GameObject.Find("HeartCounter").GetComponent<HeartCounter>();
        heartScoreText = GameObject.Find("Lives").GetComponent<TMP_Text>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            heartCounter.heartCollect.Play();
            heartCounter.heartCounter += 1;
            heartScoreText.text = "Lives: " + heartCounter.heartCounter.ToString();
            Destroy(gameObject);

        }   
    }
}
