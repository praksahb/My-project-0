using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;

    public GameObject GameWonPanel;

    public float speed;

    private bool isGameWon = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameWon)
        {
            return;
        }

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
            if(other.tag == "Door")
            {
                Debug.Log("Level Completed");
                GameWonPanel.SetActive(true);
                isGameWon = true;
            }
        }
    }
}
