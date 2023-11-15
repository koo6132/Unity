using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class SaveData
{
    public int stage;

}

public class DataManager : MonoBehaviour
{
    string path;

    void Start()
    {
        
        path = Path.Combine(Application.dataPath + "/Data/", "database.json");
        JsonLoad();
    }

    public void JsonLoad()
    {
        SaveData saveData = new SaveData();

        if (!File.Exists(path))
        {
            PlayerStage.instance.playerStage = 0;

            JsonSave();
        }
        else
        {
            string loadJson = File.ReadAllText(path);
            saveData = JsonUtility.FromJson<SaveData>(loadJson);

            if (saveData != null)
            {
                PlayerStage.instance.playerStage = saveData.stage;

            }
        }
    }

    public void JsonSave()
    {
        SaveData saveData = new SaveData();
        saveData.stage = PlayerStage.instance.playerStage;
        string json = JsonUtility.ToJson(saveData, true);

        File.WriteAllText(path, json);
    }

}