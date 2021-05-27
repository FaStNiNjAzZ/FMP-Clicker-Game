using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDropMiniGame : MonoBehaviour
{
    public GameObject deathScreen;
    public GameObject passScreen;

    int correctPasses = 0;

    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (other.gameObject.tag == "Correct Text")
            {
                correctPasses += 1;

                if (correctPasses >= 1)
                {
                    OnPass();
                }

                else
                {
                    Next();
                }
            }

            else if (other.gameObject.tag == "Wrong Text")
            {
                OnDeath();
            }   
        }    
    }

    void OnDeath()
    {
        TextDropGameResetScript.speed = 0;

        deathScreen.SetActive(true);
    }

    void OnPass()
    {
        TextDropGameResetScript.speed = 0;

        passScreen.SetActive(true);
    }

    void Next()
    {
        transform.position = new Vector3(transform.position.x+160, transform.position.y);
    }
}
