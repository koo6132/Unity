using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundUI : MonoBehaviour
{
    public GameObject A;
    public AudioSource b;

    private void Start()
    {
        b.volume = PlayerPrefs.GetFloat("SFXv");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        b.volume = PlayerPrefs.GetFloat("SFXv");
        b.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        A.SetActive(false);
    }




}
