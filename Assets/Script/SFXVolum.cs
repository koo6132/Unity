using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXVolum : MonoBehaviour
{
    public AudioClip clip;
    public AudioClip start;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void on()
    {
        SFXManager.instance.SFXSoundPlay(clip);
    }
    public void st()
    {
        SFXManager.instance.SFXSoundPlay(start);
    }
}
