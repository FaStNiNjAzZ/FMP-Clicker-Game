using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using System;

//Don't forget to use System.IO
public class MusicPlayerTest : MonoBehaviour
{
    //Directory of folder to be searched anywhere on the computer
    public string FileDirectory;

    //Audio source
    public AudioSource Source;
    //Current sound playing
    public AudioClip Clip;

    //List of all valid directories
    List<string> Files = new List<string>();
    //List of all AudioClips
    List<AudioClip> Clips = new List<AudioClip>();

    string[] files;

    public void Start()
    {
        //File Location for .MP3
        FileDirectory = Application.persistentDataPath;

        //Grabs all files from FileDirectory
        
        files = Directory.GetFiles(FileDirectory);

        //Checks all files and stores all WAV files into the Files list.
        for (int i = 0; i < files.Length; i++)
        {
            if (files[i].EndsWith(".mp3"))
            {
                Files.Add(files[i]);
                Clips.Add(new WWW(files[i]).GetAudioClip(false, true, AudioType.MPEG));
            }
        }
    }

    public void PlaySong(int _listIndex)
    {
        if (!Source.isPlaying)
        {
            Clip = Clips[_listIndex];
            Source.clip = Clip;
            Source.Play();
        } 
    }

    void Update()
    {
        var rand = UnityEngine.Random.Range(0, files.Length-1);
        PlaySong(rand);
    }
}