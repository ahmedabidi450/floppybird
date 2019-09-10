using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb2d;
    //Public variables are editable from the Inspector
    public float speed = 5f;
    //Use SerializeField to edit a variable from the inspector even if it's private
    [SerializeField]
    private float flapForce = 20f;
    //Don't forget to declare the isDead variable
    bool isDead;
    //Add an OnCollisionEnter2D function to you BirdScript
    void OnCollisionEnter2D(Collision2D col)
    {
        isDead = true;
        rb2d.velocity = Vector2.zero;
    }
    //Edit the Update function to only recieve input when the player is not dead
    void Update()
    {

        //DO NOT COPY PASTE THIS CODE, Edit the existing one

        //Only move if the player taps the screen and the bird is not dead
        if (Input.GetMouseButtonDown(0) && !isDead)
        {
            // Reset Velocity 
            rb2d.velocity = Vector2.right * speed * Time.deltaTime;
            //Add UP force to the bird
            rb2d.AddForce(Vector2.up * flapForce);
        }
    }

    // Use this for initialization
    void Start()
    {
        //Get a reference to the Rigidbody2D of the Bird
        rb2d = GetComponent<Rigidbody2D>();
        //Go right
        rb2d.velocity = Vector2.right * speed * Time.deltaTime;
    }
    // Update is called once per frame
     }

