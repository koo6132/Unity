using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1StartMusic : MonoBehaviour
{

    AudioSource audio;
    private bool hasPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.loop = false;
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.CompareTag("Player") && !hasPlayed)
        {
            audio.Play();
            hasPlayed = true;
        }

    }
}

