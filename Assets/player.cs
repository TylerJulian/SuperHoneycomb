using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{

    public static int livesLeft = 3;
    public float moveSpeed = 300f;
    public static int highScore = 0;
    float movement = 0;
    Boolean life = false;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        



    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero,Vector3.forward, movement * Time.fixedDeltaTime * moveSpeed);
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)

    {

        if (life == false)
        {
            livesLeft = livesLeft - 1;
            life = true;
        }
        else
        {
            life = false;}
        if (livesLeft <= 0)
        {
            if (hexagon.counter > highScore)
            {
                highScore = hexagon.counter;
            }
    
            hexagon.counter = 0;
            livesLeft = 3;
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex));
        }
        
}
}
