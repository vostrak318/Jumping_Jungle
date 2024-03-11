using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHero : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float jumpForce = 5f;

    private Rigidbody2D body;
    private Vector2 axisMovement;
    public Animator animator;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        axisMovement.x = Input.GetAxisRaw("Horizontal");
        if (body.velocity == Vector2.zero)
        {
            animator.SetBool("Run", false);
        }
        else
        {
            animator.SetBool("Run", true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            animator.SetBool("Jump", true);
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        body.velocity = new Vector2(axisMovement.normalized.x * speed, body.velocity.y);
        CheckForFlipping();
    }

    private void Jump()
    {
        if (Mathf.Abs(body.velocity.y) < 0.01f)
        {
            body.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void CheckForFlipping()
    {
        bool movingLeft = axisMovement.x < 0;
        bool movingRight = axisMovement.x > 0;

        if (movingLeft)
        {
            transform.localScale = new Vector3(-5f, transform.localScale.y);
        }

        if (movingRight)
        {
            transform.localScale = new Vector3(5f, transform.localScale.y);
        }
    }
}
