using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light2 : MonoBehaviour {

    public GameObject B; // 충돌 블럭

    // Start is called before the first frame update
    void Start() {
        B.SetActive(false);
    }

    // Update is called once per frame
    void Update() {


    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            B.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            B.SetActive(false);
        }
    }
}

