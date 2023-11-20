using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public int saveStage;
    public static  Portal instance;
    public int playerstage;
    public string stage;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (saveStage == 1)
            {
                SceneManager.LoadScene(stage);
                PlayerPrefs.SetInt("PlayerStage", playerstage);
                GameManager.instance.Level = stage;
                Debug.Log(SceneManager.GetActiveScene().name);
            }
            SceneManager.LoadScene(stage);
            Debug.Log("�������ϴ�");
            GameManager.instance.Level = stage;
            Debug.Log(SceneManager.GetActiveScene().name);

        }

    }
}

