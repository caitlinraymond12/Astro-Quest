using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    
    public GameObject player;
    private Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position;
        offset.y = Mathf.Abs(player.transform.position.y - transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
