using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Resultwin : MonoBehaviour
{
    public string stage;
    public int saveStage;
    public int playerstage;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SoundManager.instance.bgsound.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Endgame()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        SceneManager.LoadScene("Main");
        SoundManager.instance.bgsound.clip = null;
        MainbgmManager.instance.audioSource.volume = PlayerPrefs.GetFloat("BGMv");
        MainbgmManager.instance.audioSource.Play();
    }

}
