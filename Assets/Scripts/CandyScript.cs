﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            GameManager.instance.IncreamentScore();
            Destroy(gameObject);
        }
        else if(collider.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
        
    }
}
