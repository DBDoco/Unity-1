//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

//Na Ground se postavlja layer "Ground" te se u inspektor playera postavlja

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed;
    private float horizontalAxis;
    private bool jump;
    private float jumpSpeed = 5;
    private BoxCollider2D boxCollider2d;
    [SerializeField] private LayerMask groundLayerMask;

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
        body.velocity = new Vector2(horizontalAxis*speed, body.velocity.y);

        // jump
        if (jump && IsGrounded())
            body.velocity = new Vector2(body.velocity.x, jumpSpeed);
    }
    bool IsGrounded()
    {
        float extraHeight = 0.05f;
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, extraHeight, groundLayerMask);
        return (raycastHit.collider != null);
    }
}
