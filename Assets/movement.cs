using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    public Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        moveSpeed = 15f;
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        anim.SetBool("walk", true);

        print(moveX);

        if (moveX > 0)
        {
            spriteRenderer.flipX = false; // Player faces right
        }
        else if (moveX < 0)
        {
            spriteRenderer.flipX = true; // Player faces left
        }

        //Vector2 movement = new Vector2(moveX, moveY) * moveSpeed * Time.deltaTime;
        //rb.MovePosition(rb.position + movement);
    }
}
