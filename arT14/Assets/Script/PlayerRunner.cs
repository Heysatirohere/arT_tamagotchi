using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunner : MonoBehaviour
{
    bool isGrounded;  
    public float jumpForce = 5f;
    Rigidbody2D rb;
    public float Score = 0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
    }


    void Update()
    {
        Score += 10 * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            

        }
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        switch (collision.gameObject.tag)
        {
            case "Ground":
                isGrounded = true;
                break;
            case "Obstacle":
                GetComponent<LoadScene>().Load("SampleScene");
                break;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false; 
    }

}
