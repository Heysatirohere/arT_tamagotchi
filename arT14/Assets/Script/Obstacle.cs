using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float speed = 5f;
    Rigidbody2D rb; 
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 10); //
    }

    
    void Update()
    {
        rb.velocity = new Vector2(-speed, 0);
        
    }
}
