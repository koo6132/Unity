using System.Collections;
using UnityEngine;

public class Stage1Dadanoff : MonoBehaviour {
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject E;
    public GameObject F;
    public GameObject G;

    private bool hasPlayed = false;
    AudioSource audio;

    // Start is called before the first frame update
    void Start() {
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
        Destroy(B);
        audio.Play();

        yield return new WaitForSeconds(1f);
        Destroy(C);
        audio.Play();

        yield return new WaitForSeconds(1f);
        Destroy(D);
        audio.Play();

        yield return new WaitForSeconds(1f);
        Destroy(E);
        audio.Play();

        yield return new WaitForSeconds(1f);
        Destroy(F);
        audio.Play();

        yield return new WaitForSeconds(1f);
        Destroy(G);
        audio.Play();
    }
}