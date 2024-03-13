using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class MovementHero : MonoBehaviour
{
    public float speed = 3f;
    public float jumpForce = 5f;
    [SerializeField]private bool isGrounded;
    private Rigidbody2D rb;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(horizontalInput * speed, rb.velocity.y);
        rb.AddForce(movement, ForceMode2D.Force);

        if (Mathf.Abs(horizontalInput) > 0.1f)
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }

        if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(5, 5, 0);
        }
        else if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(-5, 5, 0);
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
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
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
