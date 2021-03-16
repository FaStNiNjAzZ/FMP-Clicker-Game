using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanLine : MonoBehaviour
{
    // Variables
    float timer = 0;
    public GameObject scanLine;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * 500);

        if (timer >= 5)
        {
            timer = 0;
            scanLine.transform.position = new Vector4((1920/2), 1280, 0);
        }

        else if (timer < 5)
        {
            timer += Time.deltaTime;
        }
    }
}
