using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float spawnRate = 3f;
   [SerializeField] GameObject obstacle; 
    void Start()
    {

        InvokeRepeating("SpawnObject", 1, spawnRate);
        
    }


    void SpawnObject() 
    {
        Instantiate(obstacle);
    
    
    
    }
}
