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
        SoundManager.instance.bgsound.loop = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onClickStartButton()
    {
        

        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        Resources.UnloadUnusedAssets();
        if(GameManager.instance.Level == "1_2")
        {
            SceneManager.LoadScene("1_2");
        }
        else if (GameManager.instance.Level == "1_3")
        {
            SceneManager.LoadScene("1_3");
        }
        else if (GameManager.instance.Level == "2")
        {
            SceneManager.LoadScene("2");
        }
        else if (GameManager.instance.Level == "3")
        {
            SceneManager.LoadScene("3");
        }
        else if (GameManager.instance.Level == "4")
        {
            SceneManager.LoadScene("4");
        }



    }
}

