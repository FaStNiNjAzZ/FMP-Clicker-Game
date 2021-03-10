using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    public static void SavePlayer(GameScript player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/AutoSave.sav";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Successful Save In " + path);
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/AutoSave.sav";
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
}