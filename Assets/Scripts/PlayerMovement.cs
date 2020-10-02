using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float playerSpeed = 10;
    float maxSpeed = 4;
    float jumpSpeed = 10;
    public bool onGround;

    public Rigidbody2D tankBody;
    
    public GravityChange gc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //Movement
        float direction = Input.GetAxis("Horizontal");
        tankBody.AddForce(Vector2.right * direction * playerSpeed, ForceMode2D.Impulse);

        if(tankBody.velocity.x > maxSpeed)
        {
            tankBody.velocity = new Vector2(maxSpeed, tankBody.velocity.y);
        }
        else if (tankBody.velocity.x < -maxSpeed)
        {
            tankBody.velocity = new Vector2(-maxSpeed, tankBody.velocity.y);
        }


        if(gc.reverseGravity == false)
        {
            if (Input.GetKey(KeyCode.Space) && onGround)
            {
                tankBody.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            }
        }
        else if(gc.reverseGravity == true)
        {
            if (Input.GetKey(KeyCode.Space) && onGround)
            {
                tankBody.AddForce(Vector2.down * jumpSpeed, ForceMode2D.Impulse);
            }
        }

        



        

    }


}
