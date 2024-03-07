using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private float defaultSpeed = 5.0f;
    private float speed;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Vector2 movementDirection;
    private float horizontalInput;
    // Start is called before the first frame update
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
        // allow the character's movement to be enabled
        speed = defaultSpeed;
    }

    public void DisableCharacter() {
        speed = 0;        
    }
}

