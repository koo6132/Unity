using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1CloseDoor : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        
=======
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
>>>>>>> Stashed changes
    }
}
