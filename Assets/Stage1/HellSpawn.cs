using System.Collections;
using UnityEngine;

public class HellSpawn: MonoBehaviour {
    public GameObject A;
    public GameObject B;
    private bool hasPlayed = false;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        A.SetActive(false);
        B.SetActive(true);
    }

    // Update is called once per frame
    void Update() {
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && !hasPlayed)
        {
            hasPlayed = true;
            A.SetActive(true);
            B.SetActive(false);
            audio.Play();
        }
    }
}