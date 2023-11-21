using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1StartMusic1 : MonoBehaviour
{
    AudioSource audio;
    public GameObject A;
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
        if (other.gameObject.CompareTag("Player"))
        {
            A.SetActive(true);
            audio.Play();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            A.SetActive(false);
        }
    }
}

