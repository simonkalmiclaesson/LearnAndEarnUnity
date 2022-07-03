﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 8f;
    private float direction = 0f;
    private Rigidbody2D player;

<<<<<<< Updated upstream:Assets/Code/_misc/OLD_PlayerMovement.cs
    public float jumpHeight = 10f;

    public Rigidbody2D rb;

    Vector2 movement;
=======
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }
>>>>>>> Stashed changes:Assets/Code/_misc/PlayerMovement.cs

    // Update is called once per frame
    void fixedUpdate()
    {
<<<<<<< Updated upstream:Assets/Code/_misc/OLD_PlayerMovement.cs
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = rb.position.y;

        if (Input.GetKey(KeyCode.Space))
        {
            movement.y = movement.y + 10;
        }
    }
=======
        direction = Input.GetAxis("Horizontal");

        if (direction > 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
        }
        else if (direction < 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
        }
        else
        {
            player.velocity = new Vector2(0, player.velocity.y);
        }
>>>>>>> Stashed changes:Assets/Code/_misc/PlayerMovement.cs

        if (Input.GetButtonDown("Jump"))
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
        }
    }
}
