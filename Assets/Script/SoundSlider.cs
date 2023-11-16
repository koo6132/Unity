using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundSlider : MonoBehaviour
{
    public Slider BGMSlider;
    public Slider SFXSlider;
    public Slider Mouse;
    public static SoundSlider instance;
    public Text text;
    
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = Mouse.value.ToString();
    }
    public void BGMVolume()
    {
        SoundManager.instance.bgsound.volume = BGMSlider.value;
        PlayerPrefs.SetFloat("BGMv", BGMSlider.value);
    }
    public void MainVolume()
    {
        MainbgmManager.instance.audioSource.volume = BGMSlider.value;
        PlayerPrefs.SetFloat("BGMv", BGMSlider.value);
    }
    public void SFXVolume()
    {
       SFXManager.instance.SFX.volume = SFXSlider.value;
        PlayerPrefs.SetFloat("SFXv", SFXSlider.value);
    }
    public void Mouses()
    {
        PlayerPrefs.SetFloat("Mouse", Mouse.value);
    }
}
