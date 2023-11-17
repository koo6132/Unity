using System.Collections;
using UnityEngine;

public class Spawnmob1: MonoBehaviour {
    public GameObject A;
    private bool hasPlayed = false;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        A.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && !hasPlayed)
        {
            hasPlayed = true;
            A.SetActive(true);
        }
    }
}