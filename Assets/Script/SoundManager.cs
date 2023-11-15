using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public AudioMixer mixer;
    public AudioSource bgsound;
    public AudioClip[] bglist;
    


    public static SoundManager instance;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnsceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }
 

    private void OnsceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        for  (int i =0; i<bglist.Length; i++)
        {
            if(arg0.name == bglist[i].name)
                BgSoundPlay(bglist[i]);
            
        }
    }

    public void BgSoundPlay(AudioClip clip)
    {
        bgsound.outputAudioMixerGroup = mixer.FindMatchingGroups("BGSound")[0];
        bgsound.clip = clip;
        bgsound.loop = true;
        
        bgsound.Play();
    }
    public void BGSoundVolume(float val)
    {
        mixer.SetFloat("BGSound", Mathf.Log10(val) * 20);
    }
   

    
   
}
