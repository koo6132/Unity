using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1LightOn : MonoBehaviour
{

    public GameObject B;
    private bool hasPlayed = false;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        B.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !hasPlayed)
        {
            B.SetActive(true);
            audio.Play();
            hasPlayed = true;
            audio.volume = PlayerPrefs.GetFloat("SFXv");

        }

    }
}

