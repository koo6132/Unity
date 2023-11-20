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

        path = Path.Combine(Application.persistentDataPath, "database.json");
        JsonLoad();
    }

    public void JsonLoad()
    {
        SaveData saveData = new SaveData();

        if (!File.Exists(path))
        {
            PlayerPrefs.SetInt("PlayerStage",0);
            PlayerPrefs.SetFloat("BGMv", 1);
            PlayerPrefs.SetFloat("SFXv", 1);
            PlayerPrefs.SetFloat("Mouse", 10);

            JsonSave();
        }
        else
        {
            string loadJson = File.ReadAllText(path);
            saveData = JsonUtility.FromJson<SaveData>(loadJson);

            if (saveData != null)
            {
                PlayerPrefs.SetInt("PlayerStage", PlayerPrefs.GetInt("PlayerStage"));
                PlayerPrefs.SetFloat("BGMv", SoundSlider.instance.BGMSlider.value);
                PlayerPrefs.SetFloat("SFXv", SoundSlider.instance.SFXSlider.value);
                PlayerPrefs.SetFloat("Mouse", SoundSlider.instance.Mouse.value);
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