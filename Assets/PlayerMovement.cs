using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool isGrounded = false;
    public Transform isGroundedChecker;
    public float checkGroundRadius;
    public LayerMask groundLayer;
    public int speed;
    public Rigidbody2D rb2d;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * speed;
        rb2d.velocity = new Vector2(x, rb2d.velocity.y);
        CheckIfGrounded();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)   
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y + jumpForce);
        }

    }
    void CheckIfGrounded()
    {
        Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer);
        if (collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
