using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    public Animator anim;
    private SpriteRenderer spirteRenderers;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        moveSpeed = 8f;
        spirteRenderers = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX, moveY) * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);

        if (movement != Vector2.zero) 
        {
            anim.SetBool("walk", true);
        }else 
        {
            anim.SetBool("walk", false);
        }

        if (moveX > 0) 
        {
            spirteRenderers.flipX = false;
        }else if (moveX < 0) 
        {
            spirteRenderers.flipX = true;
        }
    }
}
