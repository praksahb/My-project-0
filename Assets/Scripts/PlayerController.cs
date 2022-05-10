using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;

<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject gameWonPanel;

    public GameObject gameLostPanel;
=======
    public GameObject GameWonPanel;
>>>>>>> parent of 4e45434 (added game lost ui screen)

    public float speed;

    private bool isGameWon = false;

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
<<<<<<< HEAD
        if (isGameOver)
=======
        if (isGameWon)
>>>>>>> parent of 4e45434 (added game lost ui screen)
        {
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
<<<<<<< HEAD
            if (other.tag == "Door")
=======
            if(other.tag == "Door")
>>>>>>> parent of 4e45434 (added game lost ui screen)
            {
                Debug.Log("Level Completed");
                GameWonPanel.SetActive(true);
                isGameWon = true;
            }
=======
            if(other.tag == "Door")
            Debug.Log("Level Completed");
>>>>>>> parent of e3f879d (added GameWon ui screen)
        }
    }
}
