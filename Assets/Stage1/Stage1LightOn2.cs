using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1LightOn2 : MonoBehaviour
{

    public GameObject B;
    public GameObject C;
    public GameObject D;
    private bool hasPlayed = false;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(false);
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !hasPlayed) {
            B.SetActive(true);
            C.SetActive(true);
            D.SetActive(true);
            audio.Play();
            hasPlayed = true;
        }

    }
}

