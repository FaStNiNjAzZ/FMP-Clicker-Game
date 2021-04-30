using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class MusicPlayerTest : MonoBehaviour
{
    public string FileDirectory = Application.persistentDataPath;
    public AudioSource Source;
    public AudioClip Clip;

    List<string> Files = new List<string>();
    List<AudioClip> Clips = new List<AudioClip>();

    string[] files;

    public void Start()
    {
        List<string> files = new List<AudioClip>(Directory.GetFiles(FileDirectory));

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
        var rand = UnityEngine.Random.Range(0, files.Length);
        PlaySong(rand);
    }
}