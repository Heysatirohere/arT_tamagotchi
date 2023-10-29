using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 
    public PlayerRunner runner;
    void Start()
    {
       

        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + runner.Score.ToString("F1");
        
    }
}
