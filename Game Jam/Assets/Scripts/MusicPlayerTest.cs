using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

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

    public void Start()
    {
        FileDirectory = Application.persistentDataPath;
        //Source = GetComponent<AudioSource>();

        //Grabs all files from FileDirectory
        string[] files;
        files = Directory.GetFiles(FileDirectory);

        //Checks all files and stores all WAV files into the Files list.
        for (int i = 0; i < files.Length; i++)
        {
            if (files[i].EndsWith(".mp3"))
            {
                Files.Add(files[i]);
                Clips.Add(new WWW(files[i]).GetAudioClip(false, true, AudioType.MPEG));

                Clips.Add(UnityWebRequestMultimedia.GetAudioClip(files[i], AudioType.MPEG));
            }
        }
        //Calls the below method
        PlaySong(0);
    }
    public void PlaySong(int _listIndex)
    {
        Clip = Clips[_listIndex];
        Source.clip = Clip;
        Source.Play();
    }
}