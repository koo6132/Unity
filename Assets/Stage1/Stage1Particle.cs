using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1Particle: MonoBehaviour
{
    public GameObject A;
    AudioSource audio;
    private bool hasPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !hasPlayed)
        {
            Destroy(A);
            audio.Play();
            hasPlayed = true;
        }

    }
}

