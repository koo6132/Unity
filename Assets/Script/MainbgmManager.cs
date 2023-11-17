using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainbgmManager : MonoBehaviour
{
    public AudioMixer mixer;
    public static MainbgmManager instance;
    public AudioSource audioSource;
    void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        audioSource.volume = PlayerPrefs.GetFloat("BGMv");
    }


}
