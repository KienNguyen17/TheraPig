using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private float defaultSpeed = 20.0f;
    private float speed;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Vector2 movementDirection;
    private float horizontalInput;
    // Start is called before the first frame update
    private float verticalInput;
    public Animator animator;

    void Start()
    {
        speed = defaultSpeed;
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Speed", Mathf.Abs(horizontalInput));
        animator.SetFloat("HorizontalDir", (verticalInput));

        if (horizontalInput > 0) {
            spriteRenderer.flipX = true;
        }
        else if (horizontalInput < 0) {
            spriteRenderer.flipX = false;
        }
    }

    void FixedUpdate() {
        rb.velocity = movementDirection * speed;
    }

    public void EnableCharacter() {
        speed = defaultSpeed;
    }

    public void DisableCharacter() {
        speed = 0;        
    }
}

