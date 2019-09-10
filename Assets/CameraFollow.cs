﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraFollow : MonoBehaviour
{
    public Transform birdTransform;
    Vector3 range;

    void Awake()
    {
        
        range = transform.position - birdTransform.position;
    }

  
    void FixedUpdate()
    {
      
        transform.position = new Vector3(range.x + birdTransform.position.x, transform.position.y, range.z + birdTransform.position.z);
   

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

