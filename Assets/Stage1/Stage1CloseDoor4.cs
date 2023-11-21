using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1CloseDoor4 : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    private Transform TRA;
    private Transform TRB;
    private bool doorClosed = false;
    private bool rotationStarted = false;
    private float rotation = 90f;
    private float currentRotation = 30f;
    AudioSource audio;
    private bool hasPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        TRA = A.GetComponent<Transform>();
        TRB = B.GetComponent<Transform>();
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
            TRB.Rotate(Vector3.up, rotationThisFrame);

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
