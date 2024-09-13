using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Security.Policy;
using System.Drawing.Text;
using System.Xml.Linq;

public static class SaveSystem
{
    private static string SavePath(string name)
    {
        return Application.persistentDataPath + "/" + name + "_data.json";
    }

    public static void SavePlayer(PlayerData playerData)
    {
        string json = JsonUtility.ToJson(playerData);
        File.WriteAllText(SavePath(playerData.name), json);
        Debug.Log("data saved at" + SavePath(playerData.name));

    }

    public static PlayerData LoadPlayer()

    {

    Debug.Log("lets try to load something");
       
        {
            string filePath = Application.persistentDataPath + "/" + "_data.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                PlayerData playerData = JsonUtility.FromJson<PlayerData>(json);
                return playerData;
                Debug.Log("loaded" + playerData);
            }
            else
            {
                Debug.Log("save file not found");
                return null;
            }
        }
    }
}
