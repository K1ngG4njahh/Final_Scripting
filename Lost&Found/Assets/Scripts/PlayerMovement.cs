using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerMovement : MonoBehaviour
{
    
    
    public float speed;
    Rigidbody2D rb2d;
    Vector2 move;
    Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        move = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"));

        if (move != Vector2.zero)
        {
            anim.SetFloat("moveX", move.x);
            
            anim.SetBool("move", true);
        }

        else
        {
            anim.SetBool("move", false);
        }
    }
    void FixedUpdate()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb2d.MovePosition(rb2d.position + move * speed * Time.deltaTime);

        
    }
}
