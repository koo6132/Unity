using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1LightOn2 : MonoBehaviour
{

    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject E;
    public GameObject F;
    public GameObject G;
    public GameObject H;

    private bool hasPlayed = false;
    AudioSource audio;
    // Start is called before the first frame update
    void Start() {
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(false);
        E.SetActive(false);
        F.SetActive(false);
        G.SetActive(false);
        H.SetActive(false);
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && !hasPlayed) {
            E.SetActive(true);
            F.SetActive(true);
            G.SetActive(true);
            H.SetActive(true);
            hasPlayed = true;

            StartCoroutine(DisableEFG_EnableBCD());
        }
    }

    IEnumerator DisableEFG_EnableBCD()
    {
        yield return new WaitForSeconds(3f);

        E.SetActive(false);
        F.SetActive(false);
        G.SetActive(false);
        H.SetActive(false);

        B.SetActive(true);
        C.SetActive(true);
        D.SetActive(true);
    }
}

