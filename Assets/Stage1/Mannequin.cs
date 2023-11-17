using System.Collections;
using UnityEngine;

public class Mannequin : MonoBehaviour {
    public GameObject A;
    public GameObject B;

    private bool hasPlayed = false;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && !hasPlayed) {
            StartCoroutine(ActivateLightsWithDelay());
            hasPlayed = true;
        }
    }

    IEnumerator ActivateLightsWithDelay() {

        yield return new WaitForSeconds(0.1f);
        A.SetActive(true);
        B.SetActive(false);
        audio.Play();

        yield return new WaitForSeconds(1f);
        A.SetActive(false);
        B.SetActive(true);
    }
}