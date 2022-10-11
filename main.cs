using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehavior
{
    public float jump, speed;
    public bool jumping;
    public RigidBody2D body;
    
    //Use this initialization
    void Start()
    {
        body = GetComponent<RigidBody2D>();
    }
    
    //Update is called once per frame
    void Update()
    {
        Jump();
        Move();
    }
    
    private void Jump()
    {
        if(GetButtonDown("Jump"))
        {
            if(jumping == true)
            {
                
            }
            body.up = 
        }
    }
    
    private void Move()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal"), 0);
        
    }
}