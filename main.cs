using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehavior
{
    public float jump, speed;
    public bool jumping;
    public Rigidbody2D player;
    
    //Use this initialization
    void Start()
    {
        player = GetComponent<RigidBody2D>();
    }
    
    //Update is called once per frame
    void Update()
    {
        Jump();
        Move();
    }
    
    private void Jump()
    {
        if(Input.GetButtonDown("Jump") && jumping == true)
        {
            player.AddForce(new Vector2(0f, jump));
            jumping = false;
        }
    }
    
    private void Move()
    {
        Vector2 moviment = new Vector2(Input.GetAxis("Horizontal"), 0f);
        transform.position += moviment * Time.deltaTime * speed;
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.layer == 8)
        {
            jumping = true;
        }
    }
}