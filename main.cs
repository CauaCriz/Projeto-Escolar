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
        if(GetButtonDown("Jump") && jumping == true)
        {
            jump.AddForce(new Vector2(0f, ))
        }
    }
    
    private void Move()
    {
        Vector2 moviment = new Vector2(Input.GetAxis("Horizontal"), 0f);
        transform.position += moviment * Time.deltaTime * speed;
    }
}