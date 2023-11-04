using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement1 : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D rb;

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

        Vector2 movement = new Vector2(moveX, moveY) * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }
}
