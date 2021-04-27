using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MusicPlayer : MonoBehaviour
{
    List<string> songLibary = new List<string>();

    private void Awake()
    {
        string path = Application.persistentDataPath;

        
        


    }

    private void Update()
    {
        string path = Application.persistentDataPath;
        DirectoryInfo dir = new DirectoryInfo(@path);
        FileInfo[] info = dir.GetFiles("*.mp3*");
        foreach (FileInfo f in info)
        {
            songLibary.Add();
        }
    }
}