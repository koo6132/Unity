using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onClickStartButton()
    {
        PlayerPrefs.SetFloat("BGM", MainbgmManager.instance.audioSource.volume);
        MainbgmManager.instance.audioSource.volume = 0;

        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        Resources.UnloadUnusedAssets();
        switch (GameManager.instance.stage)
        {
            case 0:
                SceneManager.LoadScene("1_1");
                break;
            case 1:
                SceneManager.LoadScene("2");
                break;
            case 2:
                SceneManager.LoadScene("3");
                break;
            case 3:
                SceneManager.LoadScene("4");
                break;
        }



    }
}

