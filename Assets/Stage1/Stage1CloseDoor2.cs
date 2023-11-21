using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1CloseDoor2 : MonoBehaviour
{
    public GameObject A;
    private Transform TRA;
    private bool doorClosed = false;
    private bool rotationStarted = false;
    private float rotation = -30f;
    private float currentRotation = -30f;
    AudioSource audio;
    private bool hasPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        TRA = A.GetComponent<Transform>();
        audio = GetComponent<AudioSource>();
        audio.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (doorClosed && !rotationStarted)
        {
            float rotationThisFrame = rotation * Time.deltaTime;
            currentRotation += Mathf.Abs(rotationThisFrame);

            TRA.Rotate(Vector3.up, rotationThisFrame);

            if (currentRotation >= Mathf.Abs(rotation))
            {
                rotationStarted = true;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !doorClosed)
        {
            doorClosed = true;
        }
        if (other.gameObject.CompareTag("Player") && !hasPlayed)
        {
            audio.volume = PlayerPrefs.GetFloat("SFXv");
            audio.Play();
            hasPlayed = true;
        }
    }
}
