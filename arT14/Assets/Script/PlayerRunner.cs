using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunner : MonoBehaviour
{
    bool isGrounded;  
    public float jumpForce = 5f;
    Rigidbody2D rb; 
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        
        
        }
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;

        }
        else if (collision.gameObject.tag == "Obstacle")
        {
            GetComponent<LoadScene>().Load("SampleScene");
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false; 
    }

}
