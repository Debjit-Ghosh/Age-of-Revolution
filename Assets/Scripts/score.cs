﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class score : MonoBehaviour
{
    
    public static int scoreTotal; 
    public Text scoreText; 
    // Start is called before the first frame update
    void Start()
    {

        scoreTotal = 0; 
        
    }

    // Update is called once per frame
    void Update()
    {
        
        scoreText.text = "Score: " + scoreTotal.ToString(); 

    }


}
