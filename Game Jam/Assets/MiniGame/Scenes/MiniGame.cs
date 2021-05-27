using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame : MonoBehaviour
{
    int speed = 200;
    bool isMovingRight = false;
    bool isMovingLeft = false;
    bool isMovingUp = false;
    bool isMovingDown = false;

    bool dead = false;

    public GameObject deathScreen;
    public GameObject passScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        { 
            if (isMovingLeft == false)
            {
                Vector3 v = transform.right * speed;
                GetComponent<Rigidbody2D>().velocity = v;
                isMovingRight = true;
                isMovingLeft = false;
                isMovingUp = false;
                isMovingDown = false;
            }  
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (isMovingRight == false)
            {
                Vector3 v = -transform.right * speed;
                GetComponent<Rigidbody2D>().velocity = v;
                isMovingRight = false;
                isMovingLeft = true;
                isMovingUp = false;
                isMovingDown = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            if (isMovingDown == false)
            {
                Vector3 v = transform.up * speed;
                GetComponent<Rigidbody2D>().velocity = v;
                isMovingRight = false;
                isMovingLeft = false;
                isMovingUp = true;
                isMovingDown = false;
            }           
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            if (isMovingUp == false)
            {
                Vector3 v = -transform.up * speed;
                GetComponent<Rigidbody2D>().velocity = v;
                isMovingRight = false;
                isMovingLeft = false;
                isMovingUp = false;
                isMovingDown = true;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (dead == true)
        {

        }

        else if (dead == false)
        {
            if (other.gameObject.tag == "Wall")
            {
                Debug.Log("Dead");
                OnDeath();
            }

            if (other.gameObject.tag == "End")
            {
                OnPass();
            }
        }
        
    }

    void OnDeath()
    {
        isMovingRight = true;
        isMovingLeft = true;
        isMovingUp = true;
        isMovingDown = true;

        speed = 0;

        dead = true;

        deathScreen.SetActive(true);
    }

    void OnPass()
    {
        isMovingRight = true;
        isMovingLeft = true;
        isMovingUp = true;
        isMovingDown = true;

        speed = 0;

        dead = true;

        passScreen.SetActive(true);
    }

    public void Exit()
    {
        deathScreen.SetActive(false);
        passScreen.SetActive(false);
    }
}
