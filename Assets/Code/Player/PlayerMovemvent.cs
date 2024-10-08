using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemvent : MonoBehaviour
{
    float horizontalValue;
    SpriteRenderer rend;
    Rigidbody2D rigB;
    [SerializeField] float moveSpeed = 10;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rigB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalValue = Input.GetAxis("Horizontal");

        if (horizontalValue < 0)
        {
            Flipsprite(true);
        }

        if (horizontalValue > 0)
        {
            Flipsprite(false);
        }
    }

    private void FixedUpdate()
    {
        rigB.velocity = new Vector2(horizontalValue * moveSpeed * Time.deltaTime, rigB.velocity.y);
    }

    void Flipsprite(bool direction)
    {
        rend.flipX = direction;
    }
}
