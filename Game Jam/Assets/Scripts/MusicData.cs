using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MusicData : MonoBehaviour
{

    public string url;

    public MusicData(Music music)
    {
        url = music.url;    
    }

}