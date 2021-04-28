using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class MusicPlayer : MonoBehaviour
{
    List<string> songLibary = new List<string>();
    string file;
    public static string newPath;

    private void Awake()
    {
        string path = Application.persistentDataPath;

        
        


    }

    void Update()
    {
        string path = Application.persistentDataPath;
        DirectoryInfo dir = new DirectoryInfo(@path);
        FileInfo[] info = dir.GetFiles("*.mp3*");
        foreach (FileInfo f in info)
        {
            
        }
        newPath = Convert.ToString(info[0]);
    }

    void PlaySong()
    {

    }

    
    string url = "file:///" + newPath;

}