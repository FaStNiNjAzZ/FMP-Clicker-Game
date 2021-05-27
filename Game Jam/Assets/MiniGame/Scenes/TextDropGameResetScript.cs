using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDropGameResetScript : MonoBehaviour
{
    public static int speed = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "pitOfDoom")
        {
            Debug.Log("Detected");
            transform.position = new Vector3(transform.position.x, 640*2);
        }
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.down * speed);
    }
}
