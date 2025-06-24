using UnityEngine;

public class moveDown : MonoBehaviour
{
    
    public bool onTop = false;
    public float speed;
    private Vector3 startPos;
    public bool restart = false;
    public float minY;
    
    void Start()
    {
        startPos = transform.position;
    }
    
    void Update()
    {
        
        if(onTop && transform.position.y > minY)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        if(restart)
        {
            onTop = false;
            transform.position = startPos;
            restart = false;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            onTop = true;
        }   
    }

}
