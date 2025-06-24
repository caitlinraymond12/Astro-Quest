using UnityEngine;

public class endOfGame : MonoBehaviour
{
    
    
    public GameObject win;


    private void OnTriggerEnter2D(Collider2D other)
    {
        win.SetActive(true);
    }
}
