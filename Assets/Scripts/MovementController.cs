using UnityEngine;

public class MovementController : MonoBehaviour
{
    
    float moveSide;
    float moveUp;
    public float startTime;
    public bool grounded = true;
    public float maxSpeed = 5.0f;
    public float maxHeight = 5.0f;
    public float bouncy = 2f;
    private Animator anim;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private bool bounce;
    private AudioSource jumpEffect;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        jumpEffect = GetComponent<AudioSource>();
    }

    void Update()
    {
        moveSide = Input.GetAxis("Horizontal");
        if(moveSide < 0 && facingRight || moveSide > 0 && !facingRight )
        {
            FlipFacing();
        }
        anim.SetFloat("speed", Mathf.Abs(moveSide));
        rb.linearVelocity = new Vector2(moveSide * maxSpeed, rb.linearVelocity.y);

        if (grounded && (Input.GetMouseButtonDown(1) || Input.GetKeyDown("space")))
        {
            jumpEffect.Stop();
            jumpEffect.time = startTime;
            jumpEffect.Play();
            grounded = false;
            anim.SetBool("grounded", false);
            if(bounce)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, maxHeight*bouncy);
            }
            else
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, maxHeight);
            }
            
        }


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
            bounce = false;
            anim.SetBool("grounded", true); 
        }
        if (collision.gameObject.CompareTag("bounce"))
        {
            grounded = true;
            bounce = true;
            anim.SetBool("grounded", true);
        }
    }


    void FlipFacing()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
