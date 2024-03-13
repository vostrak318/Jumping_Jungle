using UnityEngine;

public class MovementHero : MonoBehaviour
{
    public float speed = 3f;
    public float jumpForce = 5f;
    [SerializeField] private bool isGrounded;
    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); 
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (Mathf.Abs(horizontalInput) > 0.1f)
        {
            animator.SetBool("Run", true);
            Vector2 movement = new Vector2(horizontalInput * speed, rb.velocity.y); 
            rb.velocity = movement;
        }
        else
        {
            animator.SetBool("Run", false);
        }

        if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(5, 5, 1); 
        }
        else if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(-5, 5, 1);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        else if (isGrounded)
        {
            animator.SetBool("Jump", false);
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}

