using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stage : MonoBehaviour
{
    
    public Image stageImage;
    public Text stageNameText ;
    public Button startButton;
    [SerializeField]
    private string[] stageName = { "1", "2", "3", "4" };
    public int index= 0;
    public static Stage instance;
    public int clearedStage;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("PlayerStage") < 0 || PlayerPrefs.GetInt("PlayerStage") > 4)
        {
            clearedStage = 1;
            PlayerPrefs.SetInt("PlayerStage", 1);
        }
        else clearedStage = PlayerPrefs.GetInt("PlayerStage");
    }

    private void Start()
    {
      
         index = GameManager.instance.stage; 
       stageNameText = transform.Find("Stage").GetComponent<Text>();
    }
    
    public void onClickNextStage()
    {
        index++;
        if (index >= stageName.Length)
        {
            index = 0;
            Debug.Log(index);
        }
        Debug.Log(index);
    }

    public void onClickBackStage()
    {
        index--;
        if (index < 0)
        {
            index = stageName.Length - 1;
            Debug.Log(index);
        }
        Debug.Log(index);
    }
    private void Update()
    {
        
        stageNameText.text = stageName[index];
        if (index > clearedStage)
        {
            startButton.interactable = false;
        }
        else
        {
            startButton.interactable = true;
        }

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
        switch (index)
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
