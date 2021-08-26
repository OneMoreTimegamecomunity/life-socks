using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anakarakterharaket : MonoBehaviour
{
    private float maxSpeedX;
    private float jampsizeY;
    private Rigidbody2D rb;
    public bool onGround;//zemini uzerindemi
    public bool nerdiventirmanma;
    public float horizontalInput;
    public float verticalInput;

    private bool canJump = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        // cop olan kodlar 
        #region 


        /*jampsizeY = Input.GetAxis("Vertical");
        maxSpeedX=Input.GetAxis("Horizontal");
        if (maxSpeedX>0){
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else{
            GetComponent<SpriteRenderer>().flipX = true;
        }
        myBody.velocity=new Vector2(maxSpeedX*15,myBody.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onGround == true)
            {
                myBody.velocity = new Vector2(myBody.velocity.x, 35f);

            }


        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (nerdiventirmanma == true)
            {
                myBody.velocity = new Vector2(myBody.velocity.x, jampsizeY*40);
                myBody.gravityScale = 0;
            }
           
        }
            if (nerdiventirmanma == false)
            {
                myBody.gravityScale= 10f;

            }
    */
        #endregion 

        // ziplama kodlari
        #region
        horizontalInput = Input.GetAxis("Horizontal") * 40;
        maxSpeedX = Input.GetAxis("Horizontal");
        if (maxSpeedX > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Physics2D.Raycast(transform.position,-transform.up,2.6f,LayerMask.GetMask("Ground")))
        {
            canJump = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            rb.AddForce(transform.up * 2000);
        }
        else
        {
            canJump = false;
        }

        Debug.DrawRay(transform.position, -transform.up * 2.6f);

        #endregion

        // nerdivan tirmanma kodlari 
        #region
        if (nerdiventirmanma == true)
            {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rb.velocity = new Vector2(rb.velocity.x,-40f);
                rb.gravityScale = 0;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            { 
                rb.velocity = new Vector2(rb.velocity.x,40f);
                rb.gravityScale = 0;
            }
            }

        if (nerdiventirmanma == false)
        {
           rb.gravityScale = 10f;

        }
        #endregion


        //karakter animasyonu 1. yurume 2.ziplama 3.tirmanma


    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput, rb.velocity.y);
    }

}
