using System.Collections;
using UnityEngine;

public class Stage1Dadanoff : MonoBehaviour {
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject E;
    public GameObject F;
    public GameObject G;
    public GameObject H;
    public GameObject I;
    public GameObject J;

    private bool hasPlayed = false;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        G.SetActive(false);
        H.SetActive(false);
        I.SetActive(false);
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
        Destroy(A);
        G.SetActive(true);
        audio.Play();

        yield return new WaitForSeconds(1f);
        Destroy(B);
        H.SetActive(true);
        audio.Play();

        yield return new WaitForSeconds(1f);
        Destroy(C);
        I.SetActive(true);
        audio.Play();

        yield return new WaitForSeconds(1f);
        Destroy(D);
        audio.Play();

        yield return new WaitForSeconds(1f);
        Destroy(E);
        audio.Play();

        yield return new WaitForSeconds(1f);
        Destroy(F);
        G.SetActive(false);
        H.SetActive(false);
        I.SetActive(false);
        audio.Play();
        Destroy(J);
    }
}