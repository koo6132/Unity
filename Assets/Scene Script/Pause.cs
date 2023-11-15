using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static Pause instance;
    public float mspeed;
    private bool isPause;
    public GameObject Canvas;
    public void Start()
    {
        
        Canvas.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
                Re();
            else
                stop();
        }
    }
    public void Re()
    {

    if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            
        }
        isPause = false;
        Time.timeScale = 1;
        Canvas.SetActive(false);
       SoundManager.instance.bgsound.Play();
    }

    public void stop()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            
        }
        Time.timeScale = 0;
        Canvas.SetActive(true);
        isPause = true;
        SoundManager.instance.bgsound.Pause();
        
    }
}
