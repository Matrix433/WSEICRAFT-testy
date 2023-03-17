using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;



public class movement : MonoBehaviour
{
    private Rigidbody2D ok;
    public float moveSpeed;
    public float jumpForce;
    private bool isJumping;
    private float move;
    private float jump;


    // Start is called before the first frame update
    void Start()
    {
        ok = gameObject.GetComponent<Rigidbody2D>();
        isJumping= false;
        moveSpeed = 2;
        jumpForce= 2;



        
    }

    // Update is called once per frame
    void Update()
    {

        move = Input.GetAxisRaw("horizontal");
        jump = Input.GetAxisRaw("vertical");
        
    }


    private void FixedUpdate()
    {

        if(moveSpeed != 0f)
        {
            ok.AddForce(new Vector2(move * moveSpeed, 0f), ForceMode2D.Impulse);
        }

        if (!isJumping && jump != 0f)
        {
            ok.AddForce(new Vector2(0f, jump * jumpForce), ForceMode2D.Impulse);
        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            isJumping= false;

        }
    }
}
