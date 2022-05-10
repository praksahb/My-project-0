﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;

<<<<<<< HEAD
    public GameObject gameWonPanel;

    public GameObject gameLostPanel;

    public float speed;

    private bool isGameOver = false;

=======
    public float speed;

>>>>>>> parent of e3f879d (added GameWon ui screen)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (isGameOver)
        {
            rigidbody2d.velocity = new Vector2(0f, 0f);
            return;
        }

=======
>>>>>>> parent of e3f879d (added GameWon ui screen)
        if (Input.GetAxis("Horizontal") > 0)    //positive on x-axis 
        {
            rigidbody2d.velocity = new Vector2(speed, 0f);
        }
        else if (Input.GetAxis("Horizontal") < 0)   //negative x-axis 
        {
            rigidbody2d.velocity = new Vector2(-speed, 0f);
        }
        else if (Input.GetAxis("Vertical") > 0)   //postive y-axis
        {
            rigidbody2d.velocity = new Vector2(0f, speed);
        }
        else if (Input.GetAxis("Vertical") < 0)   //negative y-axis
        {
            rigidbody2d.velocity = new Vector2(0f, -speed);
        }
        else if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            rigidbody2d.velocity = new Vector2(0f,0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        {
<<<<<<< HEAD
            if (other.tag == "Door")
            {
                Debug.Log("Level Completed");
                gameWonPanel.SetActive(true);
                isGameOver = true;
            }
            else if (other.tag == "Enemy")
            {
                Debug.Log("Level Lost");
                gameLostPanel.SetActive(true);
                isGameOver = true;
            }
=======
            if(other.tag == "Door")
            Debug.Log("Level Completed");
>>>>>>> parent of e3f879d (added GameWon ui screen)
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("button clicked");
    }
}
