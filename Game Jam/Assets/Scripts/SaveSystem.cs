using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    public static void SavePlayer(GameScript player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/PTGameManager.dat";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Successful Save In " + path);
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/PTGameManager.dat";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            Debug.Log("Successful Load In " + path);

            return data;
        }
        else
        {
            Debug.LogError("No Save Found In " + path);
            return null;
        }
    }


    public static void SaveMusic(Music player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/PTSongManager.dat";
        FileStream stream = new FileStream(path, FileMode.Create);

        MusicData data = new MusicData(player);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Successful Save In " + path);
    }

    public static MusicData LoadMusic()
    {
        string path = Application.persistentDataPath + "/PTSongManager.dat";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            MusicData data = formatter.Deserialize(stream) as MusicData;
            stream.Close();

            Debug.Log("Successful Load In " + path);

            return data;
        }
        else
        {
            Debug.LogError("No Save Found In " + path);
            return null;
        }
    }
}