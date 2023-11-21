using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class SoundSlider : MonoBehaviour
{
    public Slider BGMSlider;
    public Slider SFXSlider;
    public Slider Mouse;
    public static SoundSlider instance;
    public TextMeshProUGUI text;
    public TextMeshProUGUI BGMV;
    public TextMeshProUGUI SFXV;
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int MouseValue = Mathf.RoundToInt(Mouse.value);
        text.text = MouseValue.ToString();
        Mouse.value = PlayerPrefs.GetFloat("Mouse");

        
        BGMV.text = BGMSlider.value.ToString("F2");
        BGMSlider.value = PlayerPrefs.GetFloat("BGMv");

        
        SFXV.text = SFXSlider.value.ToString("F2");
        SFXSlider.value = PlayerPrefs.GetFloat("SFXv");
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
