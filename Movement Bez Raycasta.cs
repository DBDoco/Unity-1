//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed;
    private float horizontalAxis;
    private bool jump;
    private float jumpSpeed = 5;
    private bool grounded;
    private BoxCollider2D boxCollider2d;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        boxCollider2d = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        // controlls
        horizontalAxis = Input.GetAxis("Horizontal");  // GetAxisRaw
        jump = Input.GetKey(KeyCode.Space);
    }

    void FixedUpdate()
    {
        // left/right movement
        body.velocity = new Vector2(horizontalAxis * speed, body.velocity.y);

        // jump
        if (jump && grounded)
            body.velocity = new Vector2(body.velocity.x, jumpSpeed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = false;
    }
}
