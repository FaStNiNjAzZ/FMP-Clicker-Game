using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadGameScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gameSave1()
    {
        if (File.Exists("SaveGame1.txt"))
        {
            using (StreamWriter sw = File.CreateText("errorlog.txt"))
            {
                // sw.WriteLine("Message --- {0}", ex.Message);
            }
        }
    }
}