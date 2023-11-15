using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Source : MonoBehaviour
{
    public AudioMixer mixer;
    public static Source instance;
   
    // Start is called before the first frame update


    void Awake()
    {

    }
    

    
    public void BGSoundVolume(float val)
    {
        mixer.SetFloat("BGSound", Mathf.Log10(val) * 20);
    }
}