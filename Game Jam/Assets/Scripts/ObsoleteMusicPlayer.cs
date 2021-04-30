using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class ObsoleteMusicPlayer : MonoBehaviour
{
    List<string> songLibary = new List<string>();
    string file;
    public static string newPath;

    int songPickerRand;

    private void Awake()
    {
        string path = Application.persistentDataPath;
    }

    void Update()
    {
        var rand = new System.Random();
        string path = Application.persistentDataPath;
        DirectoryInfo dir = new DirectoryInfo(@path);
        FileInfo[] info = dir.GetFiles("*.mp3*");
        foreach (FileInfo f in info)
        {
            
        }
        newPath = Convert.ToString(info[rand.Next(info.Length)]);
    }

    void PlaySong()
    {

    }
}