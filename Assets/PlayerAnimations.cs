using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb2d;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rb2d.velocity.x < -.1 || rb2d.velocity.x > .1)
        {
            animator.SetBool("Running", true);
        } else 
        {
            animator.SetBool("Running", false);
        }
        if (rb2d.velocity.x > .1)
        { 
            sr.flipX = false;
        } else if (rb2d.velocity.x < -.1)
        {
            sr.flipX = true;

        }
        if (rb2d.velocity.y > .1)
        {
            animator.SetBool("Jumping", true);
        } else
        {
            animator.SetBool("Jumping", false);
        }
        if (rb2d.velocity.y < -.1) 
        {
            animator.SetBool("Falling", true);
        } else
        {
            animator.SetBool("Falling", false);
        }
    }
}
